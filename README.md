# 📦 Catálogo de Produtos

Uma aplicação desktop robusta e interativa desenvolvida em C# (Windows Forms) para o gerenciamento de um catálogo de produtos. Este projeto foi construído com forte ênfase em **Programação Orientada a Eventos**, componentização de layout dinâmico e separação de responsabilidades.

## ✨ Funcionalidades

* **Gestão de Produtos (CRUD):** Cadastro completo com validação rigorosa de campos (prevenção de campos vazios, tratamento de decimais com vírgula e validação de preços negativos).
* **Pesquisa Dinâmica e em Tempo Real:** Filtros aplicados instantaneamente a cada tecla digitada (usando eventos `TextChanged` e `SelectedIndexChanged`), permitindo busca combinada por nome, código, categoria e disponibilidade de estoque.
* **Feedback Visual Inteligente:** Formatação condicional da grade de dados (`DataGridView`) que destaca visualmente produtos com estoque crítico (amarelo) ou zerado (vermelho).
* **Gestão de Imagens:** Upload de fotos nativo (via `OpenFileDialog`) garantindo a preservação da proporção original das imagens (sem distorção) e funcionalidade para remoção rápida.
* **Cálculo de Promoções Dinâmico:** Regra de negócio integrada que permite habilitar descontos percentuais interativos. O preço final é projetado na tela durante a digitação e calculado sob demanda através de Propriedades Computadas, garantindo integridade dos dados.

## 🚀 Tecnologias e Conceitos Utilizados

**Linguagem & Framework:**
* C#
* .NET 8.0 (Windows Forms / WinForms)

**Engenharia de Software & Boas Práticas:**
* **Programação Orientada a Eventos:** Manipulação avançada de eventos de UI (`CellFormatting`, `CellClick`, `CheckedChanged`, manipuladores via *Expressões Lambda*) para criar uma interface ágil e responsiva.
* **Arquitetura de Layout Responsivo:** Uso extensivo de `TableLayoutPanel` e `FlowLayoutPanel`, combinados com propriedades de `Anchor` e `Dock`, dispensando o posicionamento absoluto e garantindo que a tela se adapte a diferentes resoluções.
* **Separação de Interface e Lógica (Partial Classes):** 
  * `CadastroForm.Layout.cs`: Arquivo dedicado exclusivamente à montagem visual e estilização via código.
  * `CadastroForm.cs`: Arquivo focado nas regras de negócio e manipulação de eventos.
* **Single Source of Truth (Fonte Única da Verdade):** Uso de Propriedade Computada (`PrecoFinal`) na classe modelo, evitando redundância de dados em memória e garantindo cálculos consistentes em toda a aplicação.

---

## ⚙️ Como Executar o Projeto

Como a aplicação foi desenvolvida em .NET, é necessário ter o [SDK do .NET 8.0](https://dotnet.microsoft.com/pt-br/download) (ou superior) instalado em sua máquina.

1. **Clone este repositório:**
   ```bash
   git clone https://github.com/valdirneto34/CatalogoProdutos.git
   cd CatalogoProdutos
   ```

2. **Compile e execute a aplicação:**
   Na raiz do projeto (onde está localizado o arquivo `.csproj`), execute o seguinte comando no terminal:
   ```bash
   dotnet run
   ```

---

## 📁 Estrutura do Projeto

* `Program.cs`: Ponto de entrada da aplicação, responsável por inicializar o formulário principal.
* `Produto.cs`: Entidade de domínio do sistema. Guarda as propriedades de cada item e contém a inteligência de cálculo de descontos.
* `CadastroForm.Layout.cs`: Parte da classe principal que orquestra a criação, personalização e injeção de todos os controles visuais na tela.
* `CadastroForm.cs`: Parte da classe principal que concentra as coleções de dados (`BindingList<Produto>`), os gatilhos dos botões e as validações do sistema.

---

## 👨‍💻 Autores

**[Valdir Neto](https://github.com/valdirneto34)** & **[Patrícia Silva](https://github.com/Silv-Patricia)**

Estudantes de Sistemas de Informação no IFMG-SJE.