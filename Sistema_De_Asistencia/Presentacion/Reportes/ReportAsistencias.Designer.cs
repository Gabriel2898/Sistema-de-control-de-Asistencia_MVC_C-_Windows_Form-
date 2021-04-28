namespace ORUSCURSO.Presentacion.Reportes
{
    partial class ReportAsistencias
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup6 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup7 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.table1 = new Telerik.Reporting.Table();
            this.TextBox10 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.reportHeaderSection1 = new Telerik.Reporting.ReportHeaderSection();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox19 = new Telerik.Reporting.TextBox();
            this.textBox20 = new Telerik.Reporting.TextBox();
            this.textBox21 = new Telerik.Reporting.TextBox();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.textBox23 = new Telerik.Reporting.TextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox18 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.4D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox8,
            this.textBox9,
            this.textBox11,
            this.textBox12,
            this.textBox13,
            this.textBox14});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.detail.KeepTogether = true;
            this.detail.Name = "detail";
            this.detail.PageBreak = Telerik.Reporting.PageBreak.None;
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1D);
            this.pageFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.TextBox10});
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(12D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "Reporte de Asistencia de Personal";
            // 
            // table1
            // 
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.302D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.8D)));
            this.table1.Body.SetCellContent(0, 0, this.textBox16);
            tableGroup2.Name = "group";
            tableGroup2.ReportItem = this.textBox15;
            tableGroup1.ChildGroups.Add(tableGroup2);
            tableGroup1.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.dia"));
            tableGroup1.Name = "dia";
            tableGroup1.ReportItem = this.textBox19;
            tableGroup1.Sortings.Add(new Telerik.Reporting.Sorting("=Fields.dia", Telerik.Reporting.SortDirection.Asc));
            this.table1.ColumnGroups.Add(tableGroup1);
            this.table1.Corner.SetCellContent(1, 0, this.textBox18);
            this.table1.Corner.SetCellContent(1, 3, this.textBox3);
            this.table1.Corner.SetCellContent(1, 2, this.textBox5);
            this.table1.Corner.SetCellContent(1, 1, this.textBox7);
            this.table1.Corner.SetCellContent(0, 0, this.textBox20);
            this.table1.Corner.SetCellContent(0, 1, this.textBox21);
            this.table1.Corner.SetCellContent(0, 2, this.textBox22);
            this.table1.Corner.SetCellContent(0, 3, this.textBox23);
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox20,
            this.textBox21,
            this.textBox22,
            this.textBox23,
            this.textBox18,
            this.textBox7,
            this.textBox5,
            this.textBox3,
            this.textBox16,
            this.textBox17,
            this.textBox6,
            this.textBox4,
            this.textBox2,
            this.textBox19,
            this.textBox15});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.table1.Name = "table1";
            tableGroup7.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup7.Name = "detailTableGroup";
            tableGroup6.ChildGroups.Add(tableGroup7);
            tableGroup6.Name = "group1";
            tableGroup6.ReportItem = this.textBox2;
            tableGroup5.ChildGroups.Add(tableGroup6);
            tableGroup5.Name = "group2";
            tableGroup5.ReportItem = this.textBox4;
            tableGroup4.ChildGroups.Add(tableGroup5);
            tableGroup4.Name = "group3";
            tableGroup4.ReportItem = this.textBox6;
            tableGroup3.ChildGroups.Add(tableGroup4);
            tableGroup3.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.Nombres"));
            tableGroup3.Name = "nombres";
            tableGroup3.ReportItem = this.textBox17;
            tableGroup3.Sortings.Add(new Telerik.Reporting.Sorting("=Fields.Nombres", Telerik.Reporting.SortDirection.Asc));
            this.table1.RowGroups.Add(tableGroup3);
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.779D), Telerik.Reporting.Drawing.Unit.Cm(2.1D));
            // 
            // TextBox10
            // 
            this.TextBox10.Docking = Telerik.Reporting.DockingStyle.None;
            this.TextBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.TextBox10.Style.Font.Name = "Consolas";
            this.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.TextBox10.Value = "Reporte generado por Orus 369";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(1.7D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox8.Style.Font.Bold = true;
            this.textBox8.Style.Font.Name = "Consolas";
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox8.Value = "Desde:";
            // 
            // textBox9
            // 
            this.textBox9.Format = "{0:d}";
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.3D), Telerik.Reporting.Drawing.Unit.Cm(1.7D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox9.Style.Font.Bold = false;
            this.textBox9.Style.Font.Name = "Consolas";
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox9.Value = "=Fields.desde";
            // 
            // textBox11
            // 
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4D), Telerik.Reporting.Drawing.Unit.Cm(1.7D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.2D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox11.Style.Font.Bold = true;
            this.textBox11.Style.Font.Name = "Consolas";
            this.textBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox11.Value = "Hasta:";
            // 
            // textBox12
            // 
            this.textBox12.Format = "{0:d}";
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.6D), Telerik.Reporting.Drawing.Unit.Cm(1.7D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox12.Style.Font.Bold = false;
            this.textBox12.Style.Font.Name = "Consolas";
            this.textBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox12.Value = "=Fields.hasta";
            // 
            // textBox13
            // 
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.2D), Telerik.Reporting.Drawing.Unit.Cm(1.7D));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox13.Style.Font.Bold = true;
            this.textBox13.Style.Font.Name = "Consolas";
            this.textBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox13.Value = "Semana #:";
            // 
            // textBox14
            // 
            this.textBox14.Format = "{0:d}";
            this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12D), Telerik.Reporting.Drawing.Unit.Cm(1.7D));
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox14.Style.Font.Bold = false;
            this.textBox14.Style.Font.Name = "Consolas";
            this.textBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox14.Value = "=Fields.Semana";
            // 
            // reportHeaderSection1
            // 
            this.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.4D);
            this.reportHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.table1});
            this.reportHeaderSection1.Name = "reportHeaderSection1";
            // 
            // textBox16
            // 
            this.textBox16.Format = "{0:N2}";
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.302D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox16.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox16.Style.LineColor = System.Drawing.Color.Black;
            this.textBox16.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed;
            this.textBox16.StyleName = "";
            this.textBox16.Value = "=Sum(Fields.Horas)";
            // 
            // textBox17
            // 
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.275D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox17.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox17.Style.LineColor = System.Drawing.Color.Black;
            this.textBox17.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed;
            this.textBox17.StyleName = "";
            this.textBox17.Value = "=Fields.Nombres";
            // 
            // textBox2
            // 
            this.textBox2.Format = "{0:N2}";
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.984D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox2.Style.LineColor = System.Drawing.Color.Black;
            this.textBox2.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed;
            this.textBox2.StyleName = "";
            this.textBox2.Value = "=(Fields.SueldoPorHora) * (Sum(Fields.Horas))";
            // 
            // textBox19
            // 
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.302D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox19.Style.Font.Bold = true;
            this.textBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox19.StyleName = "";
            this.textBox19.Value = "=Fields.dia";
            // 
            // textBox20
            // 
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.275D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox20.StyleName = "";
            // 
            // textBox21
            // 
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.45D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox21.StyleName = "";
            // 
            // textBox22
            // 
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.767D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox22.StyleName = "";
            // 
            // textBox23
            // 
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.984D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox23.StyleName = "";
            // 
            // textBox15
            // 
            this.textBox15.Format = "{0:d}";
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.302D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox15.Style.Font.Bold = true;
            this.textBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox15.StyleName = "";
            this.textBox15.Value = "=Fields.Fecha";
            // 
            // textBox3
            // 
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.984D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.StyleName = "";
            this.textBox3.Value = "Total bruto";
            // 
            // textBox18
            // 
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.275D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox18.Style.Font.Bold = true;
            this.textBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox18.StyleName = "";
            this.textBox18.Value = "Nombres";
            // 
            // textBox4
            // 
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.767D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox4.Style.LineColor = System.Drawing.Color.Black;
            this.textBox4.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed;
            this.textBox4.StyleName = "";
            this.textBox4.Value = "=Fields.SueldoPorHora";
            // 
            // textBox5
            // 
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.767D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox5.Style.Font.Bold = true;
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.StyleName = "";
            this.textBox5.Value = "Valor por Hr";
            // 
            // textBox6
            // 
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.45D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox6.Style.LineColor = System.Drawing.Color.Black;
            this.textBox6.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed;
            this.textBox6.StyleName = "";
            this.textBox6.Value = "=Sum(Fields.Horas)";
            // 
            // textBox7
            // 
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.45D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox7.Style.Font.Bold = true;
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox7.StyleName = "";
            this.textBox7.Value = "Total Hrs";
            // 
            // ReportAsistencias
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1,
            this.reportHeaderSection1});
            this.Name = "ReportAsistencias";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Style.Font.Name = "Consolas";
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(22.1D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.TextBox textBox1;
        internal Telerik.Reporting.TextBox TextBox10;
        public Telerik.Reporting.Table table1;
        internal Telerik.Reporting.TextBox textBox8;
        internal Telerik.Reporting.TextBox textBox9;
        internal Telerik.Reporting.TextBox textBox11;
        internal Telerik.Reporting.TextBox textBox12;
        internal Telerik.Reporting.TextBox textBox13;
        internal Telerik.Reporting.TextBox textBox14;
        private Telerik.Reporting.ReportHeaderSection reportHeaderSection1;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox19;
        private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.TextBox textBox21;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.TextBox textBox23;
        private Telerik.Reporting.TextBox textBox15;
        private Telerik.Reporting.TextBox textBox18;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox4;
    }
}