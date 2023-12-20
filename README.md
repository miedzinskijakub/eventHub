Twórcy:
    Jakub Miedziński 130617
    Małgorzata Wilczyńska 135783

Nazwa Projektu: EventHub

Opis Projektu:
    EventHub to platforma internetowa oparta na architekturze klient-serwer, zaimplementowana w technologii ASP.NET, umożliwiająca organizację, przeglądanie i uczestnictwo w różnego rodzaju wydarzeniach, takich jak konferencje, seminaria czy spotkania biznesowe. 
    Platforma ma na celu ułatwienie procesu planowania i zarządzania wydarzeniami, 
    zarówno dla organizatorów, jak i uczestników.


Opis Funkcjonalności:

1. Rejestracja i Logowanie:
    Użytkownicy mogą założyć konto, poprzez rejestrację.
    Możliwość logowania się na istniejące konta.

2. Dodawanie Wydarzeń:
    Użytkownik może tworzyć wydarzenia i jako organizator dodać informacje takie jak tytuł, data, zdjęcie, lokalizacja itp. oraz edytować je i usuwać.
    Formularz dodawania wydarzenia z intuicyjnym interfejsem.

3. Zainteresowanie Wydarzeniami:
    żytkownicy mogą wyrazić chęć uczestnictwa w wybranych wydarzeniach (jestem zainteresowany/a), po czym otrzymają potwierdzenie dodania wydarzenia do ich personalnej listy wydarzeń.

4. Przeglądanie Wydarzeń:
    Użytkownicy mają dostęp do przeglądu ogólnie dostępnych wydarzeń.
    Użytkownicy mogą wyszukiwać ogólnie dostępne wydarzenia na podstawie nazwy, opisu, lokalizacji, e-maila osoby, która dodała wydarzenie.
    Użytkownicy mają dostęp do personalnej listy wydarzeń, na które wyrazili chęć uczestnictwa i  mogą usuwać je z listy.


Cel Projektu:
    lem projektu EventHub jest stworzenie platformy, która ułatwi organizację i uczestnictwo w wydarzeniach, tworząc jednocześnie przyjazne środowisko dla użytkowników.

Technologia:
    Projekt będzie zrealizowany w technologii ASP.NET, zapewniającej solidną podstawę 
    dla aplikacji internetowych opartych na architekturze klient-serwer.


Jak uruchomić:
1. Pobrać cały projekt z GitHuba w formacie .zip i wypakować go na pulpicie.
2. Otworzyć plik eventHub.sln przy pomocy programu Visual Studio. 
3. W zakładce Narzędzia należy wybrać kolejno Menedżer pakietów NuGet i Konsola menedżera pakietów. 
4. W konsoli wykonać kolejno komendy: 

    add-migration nazwa_migracji
    update-database
 
O tyle o ile dodanie migracji może okazać się niepotrzebne, tak na pewno należy wykonać aktualizację bazy danych. 
5. Uruchomić projekt.

Projekt był sprawdzony przez kilka osób, na kilku różnych urządzeniach - stąd wiadomo, że uruchamia się poprawnie. Gdyby jednak pojawiły się problemy, prosimy o kontakt z twórcami przy pomocy Discorda c: 
