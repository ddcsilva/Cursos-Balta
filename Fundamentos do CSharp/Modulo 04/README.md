# .NET

## Instalação

Para fazer uso dos recursos do .NET, precisamos primeiro realizar a instalação dele, que se divide em duas partes: **SDK** e **Runtime**.

### Versões

As versões do .NET podem coexistir lado a lado na sua máquina, permitindo que você tenha várias versões instaladas ao mesmo tempo.

#### LTS

LTS significa Long Term Support (Suporte de Longa Duração), indicando que a Microsoft continuará a trabalhar nesta versão por um longo tempo.

### Instalação

Para instalar o .NET, acesse o site oficial [dotnet.microsoft.com](https://dotnet.microsoft.com). Evite fazer o download do Runtime ou SDK de qualquer outra fonte.

Para ir direto para o download da versão desejada, adicione os seguintes parâmetros na URL: https://dotnet.microsoft.com/`download`/`dotnet-core`/`$VERSAO`.

**Exemplo:** Para a versão 3.1, use: [https://dotnet.microsoft.com/download/dotnet-core/3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1).

Siga o assistente de instalação para seu sistema operacional. No Linux, é necessário executar alguns comandos simples.

### Requisitos Mínimos e Recomendados

| SO             | Versão Mínima | Versão Recomendada |
| -------------- | :-----------: | :----------------: |
| Windows        |      10       |         10         |
| MacOs          |  High Sierra  |      Catalina      |
| Linux (Ubuntu) |     18.04     |       20.04        |

### Runtimes

A instalação do Runtime é dividida em três partes: **ASP.NET** para aplicações Web, **Desktop** para aplicações Desktop e **.NET Core** para outras aplicações.

Para desenvolvimento, tudo o que precisamos já está no SDK instalado previamente.

## dotnet CLI

A CLI do .NET é uma ferramenta poderosa para desenvolver, compilar e gerenciar aplicações .NET.

### Verificando a versão atual instalada

```sh
dotnet --version
```

````

### Listando versões instaladas

```sh
dotnet --list-sdks
```

### Alterando versões

Use o comando global.json para especificar a versão do SDK que você deseja usar.

### Aceitando os certificados

Para desenvolvimento seguro, é necessário aceitar os certificados.

## Visual Studio Code

Visual Studio Code (VS Code) é um editor de código-fonte gratuito e poderoso da Microsoft, ideal para desenvolvimento .NET.

### Instalação do VS Code

Baixe e instale o VS Code do site oficial [code.visualstudio.com](https://code.visualstudio.com).

### Configuração para .NET

Instale a extensão C# para suporte completo ao desenvolvimento .NET no VS Code.

## Tipos de Projeto

### Aplicações Web

Desenvolva aplicações web usando ASP.NET Core.

### Aplicações Desktop

Desenvolva aplicações desktop usando Windows Forms ou WPF.

### Aplicações de Console

Desenvolva aplicações de console para tarefas automatizadas e scripts.

## Fluxo de Execução

O fluxo de execução de uma aplicação .NET envolve a compilação do código-fonte para um assembly (EXE ou DLL) e a execução desse assembly pelo .NET Runtime.

## Variáveis de Ambiente

Configure variáveis de ambiente para controlar o comportamento da aplicação em diferentes ambientes (desenvolvimento, teste, produção).

## Estrutura do App

Uma aplicação .NET típica tem uma estrutura de diretórios organizada, incluindo pastas para código-fonte, testes, configurações e dependências.

## Debug

Use ferramentas de depuração no VS Code para inspecionar e corrigir problemas no código.

### Iniciando o Debug

Defina pontos de interrupção no código e inicie a depuração usando o comando "Iniciar Depuração" no VS Code.

## Revisão

Revise o código regularmente para garantir a qualidade e a conformidade com as melhores práticas de desenvolvimento .NET.
````
