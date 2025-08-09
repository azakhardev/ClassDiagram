# 📝 Class Diagram Editor – Vizualizace tříd ve Windows Forms

## 📋 Popis

Menší školní projekt vytvořený během dvou týdnů ve Windows Forms. Úkolem bylo vytvořit nástroj pro **vizualizaci a úpravu tříd**, přičemž data mohla být ukládána buď do textového souboru, nebo do databáze – zvolil jsem **databázi**.

Projekt probíhal ve dvou fázích:

- **1. týden**: Implementace vytváření a úprav tříd (tzv. rámečků).
- **2. týden**: Možnost přidat buď pokročilé zobrazení vztahů (např. šipky mezi třídami), nebo funkce jako zoomování, pohyb v diagramu a ukládání do obrázku – zvolil jsem **druhou variantu**.

Každá třída je reprezentována pomocí komponenty `PictureBox`, která zajišťuje manipulaci s pozicí, velikostí a zobrazením. Úpravy obsahu tříd probíhají přes další okno s `DataGridView`. Nové metody a atributy se přidávají přes podokno s `TextBox` a `ListBox`.

> Novým metodám nelze přidat parametry, dokud nejsou nejprve uloženy.

## ⚙️ Funkce

- Přidávání a úprava tříd (název, atributy, metody)
- Možnost zoomování a posunu plochy (scrollování)
- Ukládání diagramu do obrázku
- Uložení dat do databáze

## 🛠️ Technologie

- **Jazyk**: C#
- **UI**: Windows Forms
- **Grafika**: GDI+
- **Datové úložiště**: SQL databáze
