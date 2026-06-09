namespace InternetKafe;

public static class FormStili
{
    public static readonly Color MenuRengi = Color.FromArgb(44, 62, 80);
    public static readonly Color PanelRengi = Color.FromArgb(62, 88, 113);
    public static readonly Color IcerikRengi = Color.FromArgb(245, 247, 250);
    public static readonly Color SecimRengi = Color.SlateGray;

    public static void Uygula(Form form)
    {
        form.BackColor = IcerikRengi;
        form.Font = new Font("Segoe UI", 10F);

        foreach (Control control in form.Controls)
            KontroluBicimlendir(control);
    }

    private static void KontroluBicimlendir(Control control)
    {
        switch (control)
        {
            case Button button:
                ButonuBicimlendir(button);
                break;
            case DataGridView grid:
                GridiBicimlendir(grid);
                break;
            case ListBox listBox:
                ListeyiBicimlendir(listBox);
                break;
            case TextBox textBox:
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.BackColor = Color.White;
                break;
            case ComboBox comboBox:
                comboBox.FlatStyle = FlatStyle.Flat;
                comboBox.BackColor = Color.White;
                break;
            case NumericUpDown numeric:
                numeric.BorderStyle = BorderStyle.FixedSingle;
                numeric.BackColor = Color.White;
                break;
            case CheckBox checkBox:
                checkBox.ForeColor = MenuRengi;
                break;
            case Panel or TableLayoutPanel:
                control.BackColor = IcerikRengi;
                break;
        }

        foreach (Control child in control.Controls)
            KontroluBicimlendir(child);
    }

    private static void ButonuBicimlendir(Button button)
    {
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.BackColor = MenuRengi;
        button.ForeColor = Color.White;
        button.Font = new Font("Noto Sans ExtBd", 10F, FontStyle.Bold);
        button.FlatAppearance.BorderColor = Color.White;
        button.FlatAppearance.MouseOverBackColor = SecimRengi;
        button.UseVisualStyleBackColor = false;
    }

    private static void GridiBicimlendir(DataGridView grid)
    {
        grid.BackgroundColor = Color.White;
        grid.BorderStyle = BorderStyle.None;
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.RowHeadersVisible = false;
        grid.EnableHeadersVisualStyles = false;
        grid.GridColor = Color.FromArgb(220, 226, 232);
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.MultiSelect = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.ColumnHeadersDefaultCellStyle.BackColor = PanelRengi;
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        grid.ColumnHeadersDefaultCellStyle.Font = new Font("Noto Sans ExtBd", 9.5F, FontStyle.Bold);
        grid.DefaultCellStyle.SelectionBackColor = SecimRengi;
        grid.DefaultCellStyle.SelectionForeColor = Color.White;
    }

    private static void ListeyiBicimlendir(ListBox listBox)
    {
        listBox.BackColor = Color.White;
        listBox.BorderStyle = BorderStyle.None;
        listBox.Font = new Font("Segoe UI", 10F);
    }
}
