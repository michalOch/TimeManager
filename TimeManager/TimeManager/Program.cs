using System;

namespace TimeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Time management app
            // Użytkownik zostaje przywitany
            // Użytkownik dostaje możliwość wyboru akcji

            // 1. Operacje na projektach (Project)
            //  1.1 Tworzenie nowego projektu
            //      1.1.1 Wprowadzenie nazwy projektu
            //      1.1.2 Wprowadzenie numeru SAP
            //      1.1.3 Wprowadzenie opisu projektu - stan projektu inicjalnie to Projektowanie
            //      1.1.4 Zwrócenie Id projektu i wyświetlenie jego podsumowania

            //  1.2 Modyfikacja projektu
            //      1.2.1 Wprowadzenie Id lub nazwy projektu
            //      1.2.2 Wyświetlenie szczegółow projektu
            //      1.2.3 Wyświetlenie wyboru rzeczy do modyfikacji 
            //              1 - Nazwa
            //              2 - Numer SAP
            //              3 - Opis projektu 
            //              4 - Stan (Enum - Projektowanie, Składanie, Uruchomienie, Testy)
            //              5 - Wróć
            //      1.2.4 - W zależności od wyboru uzupełniamy dane pole

            //  1.3 Usunięcie projektu (i związanych z nim tasków)
            //      1.3.1 Wprowadzenie Id lub nazwy projektu
            //      1.3.2 Usunięcie danego projektu razem z należącymi do niego stanami

            //  1.4 Szczególy danego projektu
            //      1.4.1 Wprowadzenie Id lub nazwy projektu
            //      1.4.2 Wyświetlenie Nazwy, Numeru Sap, i obecnego stanu projektu 

            //  1.5 Lista wszystkich projektów z taskami do tych projektów
            //      1.5.1 Wprowadzenie Id lub nazwy projektu
            //      1.5.2 Wyświetlenie listy projektów wraz z taskami (listą tasków)

            // 2. Operacja na zadaniach (Task)
            //  2.1 Tworzenie nowego zadania do danego projektu
            //      2.1.1 Wprowadzenie nazwy projektu
            //      2.1.1 Wprowadzenie nazwy zadania
            //      2.1.2 Wprowadzenie opisu zadania
            //      2.1.3 Wprowadzenie estymacji godzin dla zadania
            //      2.1.4 Stan zadania ustalony inicjalnie na nowe 
            //      2.1.5 Zwrócenie Id taska i wyświetlenie podsumowania

            //  2.2 Modyfikacja zadania
            //      2.2.1 Wprowadzenie Id zadania            
            //      2.2.2 Wyświetlenie szczegółow zadania
            //      2.2.3 Wyświetlenie wyboru rzeczy do modyfikacji 
            //              1 - Projekt
            //              2 - Nazwa
            //              3 - Opis 
            //              4 - Estymacja godzin
            //              5 - Stan (Nowe, Aktywne, Zamknięte - new, active, closed)
            //              6 - Wróć
            //      2.2.4 - W zależności od wyboru uzupełniamy dane pole

            //  2.3 Usunięcie zadania
            //      2.3.1 Wprowadzenie Id zadania            
            //      2.3.2 Usunięcie zadania o wskazanym Id

            // 3. Operacje na wpisach godzinowych (WorkLog)
            //  3.1 Dodaj nowy wpis
            //      3.1.1 Wybierz Projekt
            //      3.1.2 Wybierz Zadanie
            //      3.1.3 Wybierz Datę
            //      3.1.4 Wybierz Obecność(Present, Absent, Remote, Delegation, On Holiday, Sick Leave)
            //      3.1.5 Czas spędzony (Time Spent)
            //      3.1.6 Komentrz
            //      3.1.7 Wyświetl podsumowanie wpisanych danych
            //      3.1.8 Zwróć Id zadania

            //  3.2 Usuń dany wpisu
            //      3.2.1 Wprowadzenie Id wpisu 
            //      3.2.2 Usuń dany wpis

            //  3.3 Modyfikuj dany wpis
            //      3.3.1 Wprowadzenie Id wpisu            
            //      3.3.2 Wyświetlenie szczegółow wpisu
            //      3.3.3 Wyświetlenie wyboru rzeczy do modyfikacji 
            //              1 - Projekt
            //              2 - Zadanie
            //              3 - Datę 
            //              4 - Obecność
            //              5 - Czas spędzony na zadaniu
            //              6 - Komentarz
            //              7 - Wróc
            
            //      3.3.4 - W zależności od wyboru uzupełniamy dane pole

            //  3.4 Pokaż wszystkie wpisy dla danego projektu
            //  3.5 Pokaż wszystkie wpisy dla danego zadania
            //  3.6 Pokaż wszystkie wpisy dla danego projektu

            // 4. Raporty
            //  4.1 Ilosć godzin per projekt
            //  4.2 Ilość godzin per okres czasu (np. w danym miesiącu)
            //  4.3 Róznice między estymacją a wykonaniem zadania - do oceny efektywnośći pracownika itp.
            //  4.4 Projekty i taski
            //  4.5 Projekty i task i podsumowanie szczegółowe
            //  4.6 Taski w projekcie procentowo

            // 5. Zamknij
        }
    }
}
