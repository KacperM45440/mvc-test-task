# MVC - Test task
![image](https://github.com/user-attachments/assets/a56db7b2-0b0d-4fe0-a21f-7ed6f6b6da55)

1. Dla przycisku `'Load Content'` stwórz globalna klasę `‘custom-button’`, która może zostać wykorzystana przez inne przyciski. Klasa powinna zmienić wygląd przycisku w następujący sposób:
```
    • Szerokość 200 pixeli, wysokość 30 pixeli
    • Kolor czcionki: brown
    • Kolor tła przycisku: darkseagreen
    • Obramowanie przycisku 2px typu dashed  
    • Obramowanie w kolorze czerwonym
```
2. Dodaj drugi przycisk `‘Clear Content’`. Przycisk powinien mieć zdefiniowaną `‘custom-button’`, wyświetl `‘Clear Content’` w prawym rogu
3. Dodaj nową funkcję javascript `‘LoadContent()’` która zostanie wywołana po kliknięciu przycisku `‘Load Content’`.  Rezultatem działania funkcji powinno być dynamiczne załadowanie zawartości `‘Home/Content/ContentPartialView’` do istniejącego elementu `<div id=”ContentID”>` na stronie Index. 
4. Dodaj funkcję `‘ClearContent()’` która zostanie wywołana po kliknięciu przycisku `‘Clear Content’`. Rezultatem działania funkcji powinno być dynamiczne wyczyszczenie zawartości elementu `<div id=”ContentID”>`
5. Stwórz nową klasę `‘ComboBoxItem’` która składa się z trzech atrybutów:
```
    • ID { get;set }
    • Name { get;set }
    • FullName { get; }
```
Atrybut `‘FullName’` powinien być składowa `‘ID’` i `‘Name’` zgodnie z wzorem `„Name – [ID]”`
6. Stwórz klasę `‘DataHelper’` która posiada publiczną metodę statyczną `„GetYears(DateTime startDate)”`. Parametrem funkcji jest aktualna data, ma ona zwracać listę obiektów typu ComboBoxItem. Zwracana lista powinna zawierać lata sięgające 5 lat wstecz od aktualnej daty (parametr metody) do 5 lat po aktualnej dacie.
```
    • ID – iteracja zaczynając od 1
    • Name = rok np. ‘2023’ 
    • FullName – dynamicznie np. ‘2023 – [6]’
```
7. Dodaj na stronie `‘form’` kontrolkę `‘DropDownList’`, źródłem danych ma być metoda `DataHelper.GetYears(datetime startDate)`
8. Na stronie `‘Form’` dodaj przycisk `‘Save’` a następnie odpowiedni mechanizm, który umożliwi przesłanie zaznaczonej pozycji w komponencie `‘DropDownList’` do kontrolera `‘Home’`. Przekieruj użytkownika na nową stronę, na której będzie wyświetlona informacje `‘Data posted!’`
9. Dodaj klasę `‘Person’` która składa się z
```
    • ID (nie dopuszczamy wartości null)
    • Age (nie dopuszczamy wartość null)
    • FirstName – pole wymagane o maksymalnej długości znaków 50 i minimalnej 3
    • LastName – pole wymagane o maksymalnej długości znaków 50 i minimalnej 3
    • Email pole wymagane o maksymalnej długości znaków 100, walidacja poprawności emaila
```
10. Dodaj klasę `‘Student’` która dziedziczy po klasie `‘Person’` i składa się dodatkowo z 
```
    • University – string maksymalnie 250 znaków
```
11. Na stronie `‘Student’` dodaj formularz, który zawiera wszystkie pola (stwórz odpowiedni ViewModel) i umożliwia wprowadzenia danych i przesłanie ich do kontrolera `‘Home’`. Wyświetl komunikaty o błędach w przypadku niespełnienia reguł walidacyjnych. 
