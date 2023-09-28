
namespace Monorail
{
    partial class MonorailForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonorailForm));
            pictureBoxMonorail = new System.Windows.Forms.PictureBox();
            buttonCreate = new System.Windows.Forms.Button();
            buttonLeft = new System.Windows.Forms.Button();
            buttonRight = new System.Windows.Forms.Button();
            buttonUp = new System.Windows.Forms.Button();
            buttonDown = new System.Windows.Forms.Button();
            comboBoxStrategy = new System.Windows.Forms.ComboBox();
            buttonStep = new System.Windows.Forms.Button();
            buttonCreateAdvanced = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonorail).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMonorail
            // 
            pictureBoxMonorail.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBoxMonorail.Location = new System.Drawing.Point(0, 0);
            pictureBoxMonorail.Name = "pictureBoxMonorail";
            pictureBoxMonorail.Size = new System.Drawing.Size(882, 453);
            pictureBoxMonorail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBoxMonorail.TabIndex = 0;
            pictureBoxMonorail.TabStop = false;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            buttonCreate.Location = new System.Drawing.Point(198, 401);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new System.Drawing.Size(180, 40);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonLeft.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonLeft.BackgroundImage");
            buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonLeft.Location = new System.Drawing.Point(768, 411);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new System.Drawing.Size(30, 30);
            buttonLeft.TabIndex = 2;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += ButtonMoveClick;
            // 
            // buttonRight
            // 
            buttonRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonRight.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonRight.BackgroundImage");
            buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonRight.Location = new System.Drawing.Point(840, 411);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new System.Drawing.Size(30, 30);
            buttonRight.TabIndex = 3;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += ButtonMoveClick;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonUp.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonUp.BackgroundImage");
            buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonUp.Location = new System.Drawing.Point(804, 375);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new System.Drawing.Size(30, 30);
            buttonUp.TabIndex = 4;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += ButtonMoveClick;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonDown.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonDown.BackgroundImage");
            buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonDown.Location = new System.Drawing.Point(804, 411);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new System.Drawing.Size(30, 30);
            buttonDown.TabIndex = 5;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += ButtonMoveClick;
            // 
            // comboBoxStrategy
            // 
            comboBoxStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxStrategy.FormattingEnabled = true;
            comboBoxStrategy.Items.AddRange(new object[] { "Довести до центра", "Довести до края" });
            comboBoxStrategy.Location = new System.Drawing.Point(719, 12);
            comboBoxStrategy.Name = "comboBoxStrategy";
            comboBoxStrategy.Size = new System.Drawing.Size(151, 28);
            comboBoxStrategy.TabIndex = 6;
            // 
            // buttonStep
            // 
            buttonStep.Location = new System.Drawing.Point(768, 46);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new System.Drawing.Size(94, 29);
            buttonStep.TabIndex = 7;
            buttonStep.Text = "Шаг";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += buttonStep_Click;
            // 
            // buttonCreateAdvanced
            // 
            buttonCreateAdvanced.Location = new System.Drawing.Point(12, 401);
            buttonCreateAdvanced.Name = "buttonCreateAdvanced";
            buttonCreateAdvanced.Size = new System.Drawing.Size(180, 40);
            buttonCreateAdvanced.TabIndex = 8;
            buttonCreateAdvanced.Text = "Создать продвинутый";
            buttonCreateAdvanced.UseVisualStyleBackColor = true;
            buttonCreateAdvanced.Click += buttonCreateAdvanced_Click;
            // 
            // MonorailForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(882, 453);
            Controls.Add(buttonCreateAdvanced);
            Controls.Add(buttonStep);
            Controls.Add(comboBoxStrategy);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            Controls.Add(buttonCreate);
            Controls.Add(pictureBoxMonorail);
            Name = "MonorailForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonorail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMonorail;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        public System.Windows.Forms.ComboBox comboBoxStrategy;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Button buttonCreateAdvanced;
    }
}

