# Calculator

A simple **C# WPF** calculator for Windows, allowing you to perform basic arithmetic operations with a graphical interface.

---

## Features

- Addition, subtraction, multiplication, division.
- Support for parentheses `(` and `)`.
- Calculation order handling using a simple parser (syntax analyzer).
- Delete the last character or clear the entire expression.
- Input via **keyboard** and **button clicks**.
- Error handling, e.g., division by zero.
- Modern interface with dark theme and styled buttons.

---

## Technologies Used

- **C# 11**
- **.NET 8**
- **WPF** for the graphical interface
- Simple **MVVM** pattern (separating logic and UI)

---

## Project Structure

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

## Usage

1. Unzip the `PublicCalculator` folder.
2. Run the `Calculator.exe` application inside.
3. Use the buttons or keyboard to enter expressions.
4. Press `=` or `Enter` to calculate the result.

---

## License

This project is licensed under the MIT License.
