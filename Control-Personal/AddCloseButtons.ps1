$forms = @(
    "FR-RegistrarEmpleado",
    "FR_BeneficiosPersonal",
    "FR_ConsultarEmpleado",
    "FR_EliminarEmpleado",
    "FR_ModificarEmpleado",
    "FR_Reportes",
    "Liquidación",
    "Rol de pago"
)

$baseDir = "C:\Users\alexx\OneDrive\Desktop\Trabajos-VS\WF-Control-Personal\Control-Personal\CapaPresentacion"

foreach ($form in $forms) {
    $csPath = Join-Path $baseDir "$form.cs"
    $designerPath = Join-Path $baseDir "$form.Designer.cs"

    if ((Test-Path $csPath) -and (Test-Path $designerPath)) {
        
        # 1. Update Designer.cs
        $designerContent = Get-Content $designerPath -Raw

        # Check if already added
        if ($designerContent -notmatch "btn_cerrar_global") {
            $designerContent = $designerContent -replace '(?s)(ResumeLayout\(false\);)', @"
            // 
            // btn_cerrar_global
            // 
            this.btn_cerrar_global = new System.Windows.Forms.Button();
            this.btn_cerrar_global.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_global.Location = new System.Drawing.Point(this.ClientSize.Width - 110, this.ClientSize.Height - 40);
            this.btn_cerrar_global.Name = `"btn_cerrar_global`";
            this.btn_cerrar_global.Size = new System.Drawing.Size(95, 30);
            this.btn_cerrar_global.TabIndex = 999;
            this.btn_cerrar_global.Text = `"Cerrar`";
            this.btn_cerrar_global.UseVisualStyleBackColor = true;
            this.btn_cerrar_global.Click += new System.EventHandler(this.btn_cerrar_global_Click);
            this.Controls.Add(this.btn_cerrar_global);
            
            `$1
"@

            $designerContent = $designerContent -replace '(?s)(\s*\}\s*\}\s*)$', @"
        private System.Windows.Forms.Button btn_cerrar_global;
`$1
"@
            [IO.File]::WriteAllText($designerPath, $designerContent, [System.Text.Encoding]::UTF8)
            Write-Host "Updated $designerPath"
        }

        # 2. Update .cs
        $csContent = Get-Content $csPath -Raw
        if ($csContent -notmatch "btn_cerrar_global_Click") {
            $csContent = $csContent -replace '(?s)(\s*\}\s*\}\s*)$', @"
        private void btn_cerrar_global_Click(object sender, EventArgs e)
        {
            this.Close();
        }
`$1
"@
            [IO.File]::WriteAllText($csPath, $csContent, [System.Text.Encoding]::UTF8)
            Write-Host "Updated $csPath"
        }
    } else {
        Write-Host "Not found: $form"
    }
}
