# BlazerWebApp

Autor: Krzysztof Maciejończyk

Opis programu:

Repozytorium podzielone jest na dwa projekty. Jeden z nich zawiera podstawową wersję Blazor Web App (**-BlazerWebApp** - pierwszy projekt (zadanie 1)) z klasą Weather, rozwiniętą o dodatkowe możliwości, takie jak wyfiltrowanie zimnych dni z tabeli, wypisanie liczby ciepłych dni, czy filtracja w polu tekstowym. Poniżej przedstawiono fragmenty kodu oraz zrzuty ekranów poszczególnych funkcjonalności strony.



Drugi projekt to strona internetowa w postaci biblioteki książek (**-Reviews** - drugi projekt (zadanie 2 i 3)). W celu dostania się do bazy danych użytkownik musi na początku się zarejestrować, a następnie zalogować, ponieważ opcja wyswietlenia biblioteki książek jest blokowana bez autoryzacji. Po zalogowaniu zakładka Books wyświetla książki oraz ich ogólne informacje. Dodatkowo utworzono stronę internetową na platformie Azure.




LAB3 umożliwia użytkownikowi obliczanie wyniku mnożenia macierzy po odpowiednim wpisaniu liczby użytych w tym celu wątków oraz wielkości macierzy (NxN). Po prawidłowym uzupełnieniu, program wypisuje macierze wejściowe, czas potrzebny bibliotece Thread i Parallel do wykonania obliczeń oraz macierz wynikową. Utworzona została tutaj klasa **CustomMatrix.cs**, żeby konstruować macierze o podanym rozmiarze, uzupełniając ich pola cyframi psuedolosowymi od 1 do 9. W klasie tej też zamieszczono przeciążoną funkcję ToString(), żeby łatwiej wyświetlać macierze. Pozostałe projekty też korzystają z tej klasy, żeby przeprowadzać obliczenia.

ThreadVsParallelGUI zapewnia tę samą funkcjonalność, co poprzedni projekt, lecz tym razem w aplikacji Windows Forms. W odróżnieniu od poprzednika, program ten zezwala na kilka dodatkowych opcji. Użytkownik może wybrać, czy chce korzystać tylko z biblioteki Thread (przycisk Run Thread), tylko z biblioteki Parallel (przycisk Run Parallel), czy z obydwu bibliotek na raz (przycisk Run Both).

ImageParalleling różni się od dwóch projektów i służy do przeprowadzania czterech operacji na obrazie wejściowym. Są to negatyw, progowanie, lustrzane odbicie oraz przekształcenie do odcieni szarości. Na początku użytkownik za pomocą przycisku 'Load Image' wczytuje wybrany obraz z rozszerzeniem jpg do pamięci (w razie udanego wczytania obraz wyświetla się po lewej stronie ekranu), a przyciskiem 'Parallel Processing' rozpoczyna wielowątkowe przetwarzanie obrazów w technologii Parallel. Obrazy wynikowe pojawiają się następnie po prawej stronie ekranu.

Na koniec przeprowadzono analizę porównania czasów obliczeń za pomocą biblioteki Thread a Parallel. Poniżej zamieszczono tabelę z uśrednionymi czasami wykonywania się programu dla poszczególnych rozmiarów macierzy wejściowych oraz ilości użytych wątków:
