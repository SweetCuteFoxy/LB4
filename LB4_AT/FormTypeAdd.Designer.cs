using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LB4_AT
{
    partial class FormTypeAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelFill = new Panel();
            textBoxTypeName = new TextBox();
            labelTypeName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            errorProvider = new ErrorProvider(components);
            panelFill.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxTypeName);
            panelFill.Controls.Add(labelTypeName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(15);
            panelFill.Size = new Size(384, 156);
            panelFill.TabIndex = 0;
            // 
            // textBoxTypeName
            // 
            textBoxTypeName.Dock = DockStyle.Top;
            textBoxTypeName.Location = new Point(15, 40);
            textBoxTypeName.Name = "textBoxTypeName";
            textBoxTypeName.Size = new Size(354, 33);
            textBoxTypeName.TabIndex = 1;
            textBoxTypeName.TextChanged += TextBoxTypeName_TextChanged;
            textBoxTypeName.Validating += TextBoxTypeName_Validating;
            // 
            // labelTypeName
            // 
            labelTypeName.Dock = DockStyle.Top;
            labelTypeName.Location = new Point(15, 15);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Size = new Size(354, 25);
            labelTypeName.TabIndex = 0;
            labelTypeName.Text = "Тип аниме";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.Controls.Add(buttonSave);
            flowLayoutPanelBottom.Controls.Add(buttonCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottom.Location = new Point(0, 95);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(384, 61);
            flowLayoutPanelBottom.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(211, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(28, 13);
            buttonCancel.Margin = new Padding(3, 3, 30, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 35);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormTypeAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 156);
            Controls.Add(flowLayoutPanelBottom);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormTypeAdd";
            StartPosition = FormStartPosition.CenterScreen;
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        private Button button3;
        private Label labelTypeName;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button buttonSave;
        private Button buttonCancel;
        protected internal TextBox textBoxTypeName;
        private ErrorProvider errorProvider;
    }
}