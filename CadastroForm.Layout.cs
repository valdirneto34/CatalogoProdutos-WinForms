namespace CatalogoProdutos;

public partial class CadastroForm {

    private readonly TextBox txtPesquisa = new() {
        Dock = DockStyle.Fill,
        MaxLength = 100,
        TabIndex = 0,
        PlaceholderText = "Digite para pesquisar..."
    };
    private readonly ComboBox cmbCategoria = new() {
        Dock = DockStyle.Fill,
        TabIndex = 1,
        DropDownStyle = ComboBoxStyle.DropDownList
    };
    private readonly CheckBox chkAtivo = new() {
        Text = "Somente em estoque",
        AutoSize = true,
        TabIndex = 2
    };

    private readonly Button btnPesquisar = new() {
        Text = "Pesquisar",
        AutoSize = true,
        TabIndex = 0
    };
    private readonly Button btnLimparFiltros = new() {
        Text = "Limpar Filtros",
        AutoSize = true,
        TabIndex = 1
    };

    private readonly DataGridView grade = new() {
        Dock = DockStyle.Fill,
        ReadOnly = true,
        TabIndex = 3,
        AllowUserToAddRows = false,
        AllowUserToDeleteRows = false,
        MultiSelect = false,
        RowHeadersVisible = false,
        SelectionMode = DataGridViewSelectionMode.FullRowSelect,
        AutoGenerateColumns = true,
        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    };

    private readonly TextBox txtCodigo = new() {
        Dock = DockStyle.Fill,
        MaxLength = 100,
        TabIndex = 4
    };
    private readonly TextBox txtNome = new() {
        Dock = DockStyle.Fill,
        MaxLength = 100,
        TabIndex = 5
    };
    private readonly NumericUpDown numEstoque = new() {
        Dock = DockStyle.Fill,
        TabIndex = 6,
        Minimum = 0,
        Maximum = 9999,
        Increment = 1,
        Value = 0
    };

    private readonly RadioButton rdbAtivo = new() {
        Text = "Ativo",
        AutoSize = true,
        Checked = true,
        TabIndex = 0
    };

    private readonly RadioButton rdbInativo = new() {
        Text = "Inativo",
        AutoSize = true,
        TabIndex = 1
    };

    private readonly FlowLayoutPanel painelSituacao = new() {
        Dock = DockStyle.Fill,
        AutoSize = true,
        FlowDirection = FlowDirection.LeftToRight,
        Margin = new Padding(0)
    };

    private readonly ComboBox cmbCategoriaForm = new() {
        Dock = DockStyle.Fill,
        TabIndex = 7,
        DropDownStyle = ComboBoxStyle.DropDownList
    };

    private readonly TextBox txtPreco = new() {
        Dock = DockStyle.Fill,
        MaxLength = 100,
        TabIndex = 8
    };
    private readonly TextBox txtDataCadastro = new() {
        Dock = DockStyle.Fill,
        MaxLength = 100,
        TabIndex = 9
    };

        private readonly CheckBox chkPromocao = new() {
        Text = "Produto em Promoção",
        AutoSize = true,
        TabIndex = 10
    };

    private readonly Button btnNovo = new() {
        Text = "Novo",
        AutoSize = true,
        TabIndex = 1
    };
    private readonly Button btnSalvar = new() {
        Text = "Salvar",
        AutoSize = true,
        TabIndex = 0
    };
    private readonly Button btnExcluir = new() {
        Text = "Excluir",
        AutoSize = true,
        TabIndex = 2
    };
    private readonly Button btnCancelar = new() {
        Text = "Cancelar",
        AutoSize = true,
        TabIndex = 2
    };
    private readonly Button btnFechar = new() {
        Text = "Fechar",
        AutoSize = true,
        TabIndex = 2
    };

    private readonly Label lblStatus = new() {
        Text = "Preencha os dados do Produto.",
        AutoSize = true,
        Dock = DockStyle.Fill
    };

    private readonly ErrorProvider erros = new();

    private void MontarTela() {
        Text = "Cadastro Produtos";
        ClientSize = new Size(760, 480);
        MinimumSize = new Size(600, 400);
        StartPosition = FormStartPosition.CenterScreen;
        AutoScaleMode = AutoScaleMode.Font;
        AcceptButton = btnSalvar;

        cmbCategoria.Items.Add("Todas");
        cmbCategoria.Items.AddRange(new object[] {
            "Acessórios", "Periféricos",
        });
        cmbCategoria.SelectedIndex = 0;

        cmbCategoriaForm.Items.Add("Todas");
        cmbCategoriaForm.Items.AddRange(new object[] {
            "Acessórios", "Periféricos",
        });
        cmbCategoriaForm.SelectedIndex = 0;

        var lblPesquisa = new Label { Text = "Pesquisar por nome ou código:", AutoSize = true };
        var lblCategoria = new Label { Text = "Categoria:", AutoSize = true };
        var lblResultado = new Label { Text = "X produtos encontrados", AutoSize = true };
        var lblDadosProduto = new Label { Text = "Dados do Produto", AutoSize = true };
        var lblCodigo = new Label { Text = "Codigo:", AutoSize = true };
        var lblNome = new Label { Text = "Nome:", AutoSize = true };
        var lblEstoque = new Label { Text = "Estoque:", AutoSize = true };
        var lblSituacao = new Label { Text = "Situação:", AutoSize = true };
        var lblPreco = new Label { Text = "Preço:", AutoSize = true };
        var lblCadastro = new Label { Text = "Cadastro:", AutoSize = true };

        var layout = new TableLayoutPanel {
            Dock = DockStyle.Fill,
            Padding = new Padding(12),
            ColumnCount = 4,
            RowCount = 10
        };

        layout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        txtPesquisa.Margin = new Padding(3, 3, 24, 3);
        txtCategoria.Margin = new Padding(3, 3, 24, 3);
        txtNome.Margin = new Padding(3, 3, 24, 3);
        txtMatricula.Margin = new Padding(3, 3, 24, 3);
        cmbCurso.Margin = new Padding(3, 3, 24, 3);

        layout.Controls.Add(lblNome, 0, 0);
        layout.Controls.Add(txtNome, 1, 0);

        layout.Controls.Add(lblMatricula, 0, 1);
        layout.Controls.Add(txtMatricula, 1, 1);

        layout.Controls.Add(lblCurso, 0, 2);
        layout.Controls.Add(cmbCurso, 1, 2);

        var botoes = new FlowLayoutPanel {
            Dock = DockStyle.Fill,
            AutoSize = true,
            TabIndex = 2
        };
        botoes.Controls.AddRange(new Control[]{
        btnSalvar, btnNovo, btnExcluir
        });
        layout.Controls.Add(botoes, 0, 3);
        layout.SetColumnSpan(botoes, 3);

        layout.Controls.Add(grade, 0, 4);
        layout.SetColumnSpan(grade, 2);
        layout.Controls.Add(lblStatus, 0, 5);
        layout.SetColumnSpan(lblStatus, 2);
        Controls.Add(layout);
    }
}