﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Uno.Extensions;

namespace Uno.UWPSyncGenerator
{
	class SyncGenerator : Generator
	{
		protected override void ProcessType(INamedTypeSymbol type, INamespaceSymbol ns)
		{
			var folder = $@"{GetNamespaceBasePath(type)}\{ns}";
			var info = Directory.CreateDirectory(folder);

			// Console.WriteLine(type.ToString());

			// if (type.Name == "BrushCollection" || type.Name == "StringMap")
			// if (type.Name == "StatusBar")
			{
				using (var typeWriter = new StreamWriter(Path.Combine(folder, type.Name) + ".cs"))
				{
					var b = new IndentedStringBuilder();

					b.AppendLineInvariant($"#pragma warning disable 108 // new keyword hiding");
					b.AppendLineInvariant($"#pragma warning disable 114 // new keyword hiding");
					using (b.BlockInvariant($"namespace {ns}"))
					{
						WriteType(type, b);
					}

					typeWriter.Write(b.ToString());
				}
			}
		}
		private void WriteType(INamedTypeSymbol type, IndentedStringBuilder b)
		{
			var kind = type.TypeKind;
			var partialModifier = type.TypeKind != TypeKind.Enum ? "partial" : "";
			var allSymbols = GetAllSymbols(type.ContainingNamespace + "." + type.MetadataName);

			var staticQualifier = (type.IsAbstract && type.IsSealed) ? "static" : "";

			if (SkippedType(type))
			{
				b.AppendLineInvariant($"// Skipped type, see SkippedType method");
				return;
			}

			var writtenSymbols = new List<ISymbol>();

			if (type.TypeKind == TypeKind.Delegate)
			{
				BuildDelegate(type, b, allSymbols, writtenSymbols);
			}
			else
			{
				if (type.Name == "DependencyObject")
				{
					kind = TypeKind.Interface;
				}


				if (type.TypeKind == TypeKind.Enum)
				{
					allSymbols.AppendIf(b);
				}

				allSymbols.AppendIf(b);
				b.AppendLineInvariant($"[global::Uno.NotImplemented]");
				b.AppendLineInvariant($"#endif");

				using (b.BlockInvariant($"public {staticQualifier} {partialModifier} {kind.ToString().ToLower()} {type.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat)} {BuildInterfaces(type)}"))
				{
					if (type.TypeKind != TypeKind.Enum)
					{
						BuildProperties(type, b, allSymbols, writtenSymbols);
						BuildMethods(type, b, allSymbols, writtenSymbols);
						BuildEvents(type, b, allSymbols, writtenSymbols);
					}

					BuildFields(type, b, allSymbols, writtenSymbols);

					if (type.TypeKind != TypeKind.Enum)
					{
						BuildInterfaceImplementations(type, b, allSymbols, writtenSymbols);
					}
				}

				if (type.TypeKind == TypeKind.Enum)
				{
					b.AppendLineInvariant($"#endif");
				}
			}
		}
	}
}
