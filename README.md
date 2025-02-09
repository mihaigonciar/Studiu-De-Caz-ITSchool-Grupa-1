# Considerente Generale #

### Diagrama Logica ###
`Not available`

### Design Mock-up ###
`Not available`

### Stack de tehnologii ###
- Versiune .NET: 8.0
- Limbaje de programare: C#
- Interfata grafica: Windows Forms

### Structura Aplicatiei ###
Solutia este formata din 2 proiecte:
- `StudiuDeCaz1.Backend` => Proiect tip librarie de clase. Contine clasa `Contact` si `ContactFactory`, care impreuna gestioneaza datele datele si stocarea lor.
- `StudiuDeCaz1.Frondend` => Proiect de tip Windows Forms Application. Contine diverse `Forms` si `UserControls` construite in jurul claselor de backend si gestioneaza rularea aplicatiei.

# Prezentarea Aplicatiei Grafice #

### Fereastra Principala ###
Ii permite utilizatorului sa:
- vizualizeze toate contactele existente, sub forma de lista
- adauge un contact nou (prin apasarea simbolul `+` din partea dreapta-sus a ferestrei)
- editeze oricare dintre contactele disponibile (prin apasarea benzii verzi a oricarui contact)

Cardurile contactelor ofera de asemenea si urmatoarele functii:
- **Trimite email** (`mailto:`) - prin apasarea link-ului cu emailul unui contact. Acest buton va porni aplicatia implicita de mail a computerului.
- **Apeleaza** (`tel:`) - prin apasarea link-ului cu numarul de telefon al unui contact. Acest buton va porni aplicatia implicita de apel a computerului.

![image](https://github.com/user-attachments/assets/1938b581-45d1-45ea-a628-a5605a52fd72)

### Adaugare / Editare Contact ###
Ferestrele de adaugare si editare contact folosesc acelasi Form.
Elementele din grupul `Needed` sunt obligatorii, in timp ce cele din `Optional` pot fi omise.
Utilizatorul are la dispozitie urmatoarele shortcut-uri:
- `Enter` => Actioneaza butonul `Submit` (verifica datele de intrare si le executa daca este posibil).
- `Esc` => Actioneaza butonul `Cancel` (inchide Fereastra deschisa).

![image](https://github.com/user-attachments/assets/f38a338c-8c9a-43a0-9c86-b51e44328fe6)

In modul de editare, campurile de text sunt pre-completate cu datele deja existente ale contactului selectat: 

![image](https://github.com/user-attachments/assets/e1b2e1f5-3791-454e-8848-e312969fc656)

