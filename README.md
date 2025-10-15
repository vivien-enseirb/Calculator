# Calculator

Une calculatrice simple en **C# WPF** pour Windows, permettant de faire des calculs basiques avec une interface graphique.

---

## Fonctionnalités

- Addition, soustraction, multiplication, division.
- Gestion des parenthèses `(` et `)`.
- Gestion des priorités de calcul en utilisant des bases de compilation (analyseur syntaxique)
- Effacement du dernier caractère ou de toute l'expression.
- Support des entrées via **clavier** et **clic sur boutons**.
- Gestion des erreurs, par exemple division par zéro.
- Interface moderne avec thèmes sombre et boutons stylisés.

---

## Technologies utilisées

- **C# 11**
- **.NET 8**
- **WPF** pour l'interface graphique
- **MVVM simple** (pour séparer logique et interface)

---

## Structure du projet

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

## Utilisation

1. Ouvrir le projet dans **Rider** ou **Visual Studio**.
2. Construire le projet.
3. Lancer l'application.
4. Utiliser les boutons ou le clavier pour saisir des expressions.
5. Appuyer sur `=` ou `Enter` pour obtenir le résultat.

---


## Licence

Ce projet est sous licence MIT. 