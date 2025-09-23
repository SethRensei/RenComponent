# 📘 README – RenComponent (Français)

## 🚀 Présentation

**RenComponent** est une librairie de composants personnalisés pour **Windows Forms (.NET Framework / .NET WinForms)**.
Elle permet d’avoir des contrôles modernes, stylisés et facilement réutilisables (boutons arrondis, DataGridView paginé, ComboBox custom, ProgressBar circulaire, etc.).

👉 Le projet contient deux parties :

* **RenComponent** : bibliothèque de composants réutilisables.
* **RenTestComponent** : application WinForms servant de **démo** et de **terrain de test** pour ces composants.

---

## 📂 Structure du projet

```
RenComponent/
│── Properties/
│── Resources/
│   ├── PaginatedDataGridView.cs
│   ├── RenButton.cs
│   ├── RenCircularProgressBar.cs
│   ├── RenComboBox.cs
│   ├── RenDatePicker.cs
│   ├── RenPanel.cs
│   ├── RenRadioButton.cs
│   ├── RenTextBox.cs
│   ├── RenToggleButton.cs
│   └── ...
│── RenComponent.csproj
│
RenTestComponent/
│── Form1.cs
│── Program.cs
│── RenTestComponent.csproj
```

---

## 🧩 Composants disponibles

### ✅ Boutons

* `RenButton` → Bouton personnalisable (coins arrondis, couleur, bordure).
* `RenToggleButton` → Switch On/Off moderne.
* `RenRadioButton` → Radio stylisé.

### ✅ Entrées utilisateur

* `RenTextBox` → TextBox custom avec bordure colorée.
* `RenComboBox` → ComboBox moderne avec design plat.
* `RenDatePicker` → Sélecteur de date stylisé.

### ✅ Layouts

* `RenPanel` → Panel avec bordure/couleur personnalisée.

### ✅ Visualisation

* `RenCircularProgressBar` → ProgressBar circulaire avec pourcentage.
* `PaginatedDataGridView` → DataGridView avec pagination intégrée (boutons `RenButton`).

---

## ⚙️ Installation

1. Ouvre la solution `.sln` dans Visual Studio.
2. Compile **RenComponent** → cela génère une DLL (`RenComponent.dll`).
3. Dans ton projet WinForms, ajoute une référence à **RenComponent.dll**.
4. Les nouveaux composants apparaîtront dans la **Boîte à outils** de Visual Studio (Toolbox).

---

## 🖥️ Exemple d’utilisation

### Exemple avec `PaginatedDataGridView`

```csharp
using System;
using System.Data;
using System.Windows.Forms;
using RenComponent;

namespace Demo
{
    public partial class Form1 : Form
    {
        private PaginatedDataGridView grid;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new PaginatedDataGridView
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(grid);

            // Générer des données fictives
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nom", typeof(string));
            dt.Columns.Add("Email", typeof(string));

            for (int i = 1; i <= 50; i++)
            {
                dt.Rows.Add(i, $"User {i}", $"user{i}@mail.com");
            }

            // Charger dans le composant
            grid.SetData(dt);
        }
    }
}
```

---

## 🧪 Projet de test : **RenTestComponent**

Le projet **RenTestComponent** sert uniquement de **démo**.
Il permet de voir rapidement comment les composants réagissent dans un vrai formulaire.

👉 Exemple d’écran de démo :

* Boutons personnalisés.
* TextBox stylisées.
* ComboBox modernes.
* ProgressBars circulaires.
* **DataGridView paginé** avec navigation.

---

## 📜 Licence

Projet libre d’utilisation et d’adaptation (MIT ou autre selon ton choix).