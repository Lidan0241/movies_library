# Movie Library - README

## Description

**Movie Library** est une application en ligne de commande permettant de gérer une collection personnelle de films.

---

## Fonctionnalités

### 1. Ajouter un film
- **Commande** : `add`  
  Permet d'ajouter un film à la collection. L'utilisateur est invité à saisir les détails du film (titre, réalisateur, année, genre). L'année doit être au format XXXX numérique, sinon saisie invalide.

### 2. Rechercher un film
- **Commande** : `search <mot-clé>`  
  Recherche un film dans la collection en fonction du titre, du réalisateur ou du genre, et affiche les résultats correspondants.

### 3. Exporter la collection de films
- **Commande** : `export <format>`  
  Exporte la collection de films dans un fichier au format spécifié. Formats pris en charge :
  - `json` : Exporte dans `data/export.json`
  - `txt` : Exporte dans `data/export.txt`

### 4. Écrire un fichier texte
- **Commande** : `writetext`  
  Demande à l’utilisateur d’entrer un nom de fichier et un contenu, puis écrit ce contenu dans le fichier texte spécifié.

### 5. Lire un fichier structuré
- **Commande** : `readstructured`  
  Lit un fichier `.json` contenant des films et ajoute les films à la collection existante.

### 6. Écrire un fichier structuré
- **Commande** : `writestructured`  
  Demande à l’utilisateur d’entrer un nom de fichier et sauvegarde la collection actuelle dans un fichier au format `.json`.

### 7. Changer la langue
- **Commande** : `language <lang>`  
  Permet de changer la langue de l’application. Langues disponibles :
  - `en` : Anglais
  - `zh` : Chinois

### 8. Afficher l’aide
- **Commande** : `help`  
  Affiche la liste des commandes disponibles ainsi que leur description.

---

## Commandes disponibles

| Commande             | Description                                    |
|----------------------|------------------------------------------------|
| `add`                | Ajoute un film à la collection                 |
| `search <mot-clé>`   | Recherche un film                              |
| `export <format>`    | Exporte la collection (json/txt)               |
| `readstructured`     | Lit un fichier JSON structuré                  |
| `writestructured`    | Sauvegarde la collection dans un fichier JSON  |
| `writetext`          | Écrit un fichier texte avec du contenu saisi   |
| `language <code>`    | Change la langue de l'application              |
| `help`               | Affiche l’aide                                 |

---

## Exemples d'utilisation

1. **Ajouter un film**  
   ```bash
   > add  
   Title: Inception  
   Director: Christopher Nolan  
   Year: 2010  
   Genre: Science Fiction  
   Movie added successfully!
   ```
2. **Chercher un film**
   ```bash
   > search Inception  
    Title: Inception, Director: Christopher Nolan, Year: 2010, Genre: Science Fiction
   ```
3. **Exporter la collection au format JSON**
   ```bash
   > export json  
    Please specify export format (json/txt)  
    Movies exported to data/export.json
   ```
4. Changer la langue en chinois
   ```bash
   > language zh  
    Available languages:  
    - en (English)  
    - zh (Chinese)  

    Current language: zh  
    Language changed to: zh
   ```

5. Écrire un fichier texte
   ```bash
   > writetext  
    Enter file name: notes.txt  
    Enter content (press Ctrl+Z and Enter when done):  
    This is a sample note.  
    [Ctrl+Z pressed]  
    Content written to data/notes.txt
   ```


