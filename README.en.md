# 📘 README – RenComponent (English)

## 🚀 Overview

**RenComponent** is a custom **Windows Forms (.NET Framework / .NET WinForms)** UI library.
It provides modern, stylish, and reusable controls such as rounded buttons, a paginated DataGridView, custom ComboBoxes, circular progress bars, and more.

👉 The solution contains two projects:

* **RenComponent** → The reusable component library.
* **RenTestComponent** → A demo/testing WinForms app showcasing the components.

---

## 📂 Project Structure

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

## 🧩 Available Components

### ✅ Buttons

* `RenButton` → Fully customizable button (rounded corners, border, background color).
* `RenToggleButton` → Modern On/Off switch.
* `RenRadioButton` → Custom styled radio button.

### ✅ Input Controls

* `RenTextBox` → Styled TextBox with custom borders and placeholder.
* `RenComboBox` → Flat, modern-styled ComboBox.
* `RenDatePicker` → Custom DateTime picker.

### ✅ Layout

* `RenPanel` → Customizable Panel with border and color options.

### ✅ Visualization

* `RenCircularProgressBar` → Circular progress bar with percentage.
* `PaginatedDataGridView` → DataGridView with built-in pagination and styled navigation buttons (`RenButton`).

---

## ⚙️ Installation

1. Open the `.sln` solution in Visual Studio.
2. Build **RenComponent** → this will generate a `RenComponent.dll`.
3. In your WinForms project, add a reference to **RenComponent.dll**.
4. The new controls will appear in the **Visual Studio Toolbox**.

---

## 🖥️ Usage Example

### Example with `PaginatedDataGridView`

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

            // Generate dummy data
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Email", typeof(string));

            for (int i = 1; i <= 50; i++)
            {
                dt.Rows.Add(i, $"User {i}", $"user{i}@mail.com");
            }

            // Load into the component
            grid.SetData(dt);
        }
    }
}
```

---

## 🧪 Test Project: **RenTestComponent**

The **RenTestComponent** project is a **demo app**.
It is meant to showcase the components in action, with ready-to-use examples:

* Custom buttons
* Styled TextBoxes
* Modern ComboBoxes
* Circular progress bars
* **Paginated DataGridView** with navigation buttons

---

## 📜 License

Free to use and adapt (MIT or another license of your choice).