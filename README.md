# CSharp9.0-TopLevelTest
Um teste simples da nova funcionalidade do C# 9.0: Top-Level Statements

No momento da criação deste repositório, o C#9.0 ainda está em fase de preview. Portanto, para poder testar esta nova funcionalidade, alguns passos devem ser seguidos.


**Passo 1:** Visual Studio no mínimo na versão 16.7.0.
  Para atualizar o Visual Studio, basta ir em: Help -> Check for Updates
 
**Passo 2:** Baixar e instalar o SDK do .NET 5.0.
  Disponível na documentação oficial da Microsoft no link: https://dotnet.microsoft.com/download/dotnet/5.0
  

Pronto! Agora você já poderá clona este repositório e brincar com esta nova feature.


E caso queira criar um projeto pessoal utilizando o Top-Level Statement, enquanto esta versão não é lançada oficialmente, você deve substituir o conteúdo do .csproj do seu projeto alterando pelo seguinte:
```
<Project Sdk="Microsoft.NET.Sdk">
	<PropertyGroup>
		<OutputType>Exe</OutputType>
		<TargetFramework>net5.0</TargetFramework>
		<LangVersion>9.0</LangVersion>
	</PropertyGroup>
</Project>
```
