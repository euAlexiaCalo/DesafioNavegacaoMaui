# 🗺️ Desafio de Navegação — .NET MAUI (C#)

![.NET](https://img.shields.io/badge/.NET%20MAUI-8A2BE2?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=white)
![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)

---

## 📖 Descrição

Aplicação de demonstração em **.NET MAUI** focada em gerenciar o fluxo de navegação e um desafio básico de login, utilizando o padrão **MVVM (Model-View-ViewModel)**.

O app demonstra um fluxo completo de tela de entrada, tela de login com validação e tela inicial de sucesso.

**Objetivo:** demonstrar de forma prática o uso de **Shell Routing**, **Commands**, **Data Binding** e **separação de responsabilidades** com MVVM em um aplicativo .NET MAUI.

---

## ⚙️ Principais recursos

- Navegação entre três telas (**MainPage → LoginPage → HomePage**) usando `Shell.Current.GoToAsync()`
- Tela de Login com campos de **Email** e **Senha**
- **Validação simples** de campos vazios antes do login
- Lógica de autenticação **simulada** com credenciais fixas  
  → Email: `email@email.com`  
  → Senha: `1234`
- Uso de `INotifyPropertyChanged` para manter a UI sincronizada com os ViewModels
- Comando para **Retornar ao Início** (`//MainPage`)

---

## 🧩 Telas do App
1. **MainPage** — Tela inicial com botão *Acessar*  
2. **LoginPage** — Tela de login com validação de credenciais  
3. **HomePage** — Tela principal exibida após login bem-sucedido, com botão *Sair*  

---

## 🧱 Estrutura MVVM
| Camada | Arquivos | Função |
|--------|-----------|--------|
| **View** | `MainPage.xaml`, `LoginPage.xaml`, `HomePage.xaml` | Interface e layout visual |
| **ViewModel** | `MainViewModel.cs`, `LoginViewModel.cs`, `HomeViewModel.cs` | Lógica, comandos e propriedades |
| **Shell** | `AppShell.xaml.cs` | Define rotas e controle de navegação entre páginas |
| **App.xaml** | Configuração geral da aplicação |

---

## 💻 Pré-requisitos
- **Windows 10/11**  
- **Visual Studio 2022+** com a carga de trabalho **“.NET Multi-platform App UI development (MAUI)”**  
  - Inclui Android SDKs e Emulador Android  
- **.NET SDK** compatível com MAUI já instalado  
- (Opcional) **Dispositivo Android** ou emulador configurado

```bash
dotnet workload install maui

---

## Como obter o projeto

## 🔹 Opção 1 — Git (recomendado)
git clone https://github.com/seu-usuario/DesafioNavegacaoMaui.git
cd DesafioNavegacaoMaui

## 🔹 Opção 2 — Download

1. Baixe o **.zip** do repositório  
2. Extraia em uma pasta local  
3. Abra o arquivo **.sln** no Visual Studio

---

## 🔧 Executando o App

1. Abra a solução no **Visual Studio**  
2. Selecione o destino (ex: **Android Emulator**, **Windows Machine**)  
3. Clique em **Run / Play (F5)**  

---

## 📝 Como Usar

O fluxo de navegação é sequencial:

1. **Tela Principal (MainPage)**  
   → Clique no botão **Acessar**

2. **Tela de Login (LoginPage)**  
   → Preencha os campos  
   → **Credenciais de Teste:**  
   - E-mail: `email@email.com`  
   - Senha: `1234`  
   → Clique em **Acessar**

3. **Tela Inicial (HomePage)**  
   → Exibe a confirmação de login  
   → Clique em **Sair** para retornar à **MainPage** (navegação absoluta com `//`)

---

## 🏗️ Estrutura MVVM e Roteamento

Este projeto utiliza o padrão **MVVM** com roteamento gerenciado pelo **Shell**:

- `MainPage.xaml` / `MainViewModel.cs`: Lida com o comando para navegar para a tela de Login  
- `LoginPage.xaml` / `LoginViewModel.cs`: Gerencia os campos de Email e Senha e o comando de login, incluindo a lógica de validação simulada  
- `HomePage.xaml` / `HomeViewModel.cs`: Contém o comando para realizar o logout e retornar à tela principal  
- `AppShell.xaml.cs`: Responsável por registrar as rotas de navegação (**MainPage**, **LoginPage**, **HomePage**) usando `Routing.RegisterRoute`

---

## 📁 Estrutura do Projeto (Chave)

/DesafioNavegacaoMaui
├─ Views/
│ ├─ MainPage.xaml
│ ├─ LoginPage.xaml
│ └─ HomePage.xaml
├─ ViewModels/
│ ├─ MainViewModel.cs
│ ├─ LoginViewModel.cs
│ └─ HomeViewModel.cs
├─ AppShell.xaml (Registro de Rotas)
└─ App.xaml

---

## 🚀 Roadmap

- 🔐 Substituir a autenticação mockada por um serviço real (e.g., Firebase, Azure B2C)  
- 📧 Adicionar validações de formato de Email mais robustas  
- 🎞️ Implementar animações de transição de tela personalizadas  
- 📱 Melhorar o design responsivo das telas de login  

---

## 🤝 Contribuindo

1. Faça um **Fork**  
2. Crie uma branch: `feat/sua-melhoria`  
3. Faça o **Commit**  
4. Envie um **Pull Request**

---

## 📜 Licença

Este projeto está sob a licença **MIT**.  
Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
