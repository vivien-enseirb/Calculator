# Calculator

[If you prefer the english version](#english-section)

## Section française

Une calculatrice simple en **C# WPF** pour Windows, permettant de faire des calculs basiques avec une interface graphique.

---

### Fonctionnalités

- Addition, soustraction, multiplication, division. Attention, ne gere que les entiers (donc $x/y=0$ si $x < y$ )
- Gestion des parenthèses `(` et `)`.
- Gestion des priorités de calcul en utilisant des bases de compilation (analyseur syntaxique)
- Effacement du dernier caractère ou de toute l'expression.
- Support des entrées via **clavier** et **clic sur boutons**.
- Gestion des erreurs, par exemple division par zéro.
- Interface moderne avec thèmes sombre et boutons stylisés.

---

### Technologies utilisées

- **C# 11**
- **.NET 8**
- **WPF** pour l'interface graphique
- **MVVM simple** (pour séparer logique et interface)

---

### Structure du projet

Calculator/

├── Calculator.sln # Solution

├── Calculator/ # Projet principal

│ ├── MainWindow.xaml # Interface graphique

│ ├── MainWindow.xaml.cs # Code-behind de l'UI

│ ├── Services/ # Services de calcul

│ │ └── MathUtils/ # Fonctions de calcul

│ └── App.xaml # Configuration WPF

├── .gitignore

└── README.md

### Utilisation

1. Decompresser `PublicCalculator` pour utilisateur windows `PublicCalculator_LinuxCompat` sinon
2. Lancer l'application `Calculator.exe` ou `Calculator` qui s'y trouve.
3. Utiliser les boutons ou le clavier pour saisir des expressions.
4. Appuyer sur `=` ou `Enter` pour obtenir le résultat.

---


### Licence

Ce projet est sous licence MIT. 

## English section

A simple **C# WPF** calculator for Windows, allowing you to perform basic arithmetic operations with a graphical interface.

---

### Features

- Addition, subtraction, multiplication, division. Be careful, only integers are considered (then $x/y=0$ if $x < y$)
- Support for parentheses `(` and `)`.
- Calculation order handling using a simple parser (syntax analyzer).
- Delete the last character or clear the entire expression.
- Input via **keyboard** and **button clicks**.
- Error handling, e.g., division by zero.
- Modern interface with dark theme and styled buttons.

---

### Technologies Used

- **C# 11**
- **.NET 8**
- **WPF** for the graphical interface
- Simple **MVVM** pattern (separating logic and UI)

---

### Project Structure

Calculator/

├── Calculator.sln           # Solution file

├── Calculator/              # Main project

│   ├── MainWindow.xaml      # UI layout

│   ├── MainWindow.xaml.cs   # UI code-behind

│   ├── Services/            # Calculation services

│   │   └── MathUtils/       # Math utility functions

│   └── App.xaml             # WPF configuration

├── .gitignore

└── README.md

---

### Usage

1. Unzip the `PublicCalculator` folder or `PublicCalculator_LinuxCompat` if you don't use Windows.
2. Run the `Calculator.exe` or `Calculator` application inside.
3. Use the buttons or keyboard to enter expressions.
4. Press `=` or `Enter` to calculate the result.

---

### License

This project is licensed under the MIT License.
