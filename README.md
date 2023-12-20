# EventHub

## Twórcy
- Jakub Miedziński (130617)
- Małgorzata Wilczyńska (135783)

## Opis Projektu
EventHub to platforma internetowa oparta na architekturze klient-serwer, zaimplementowana w technologii ASP.NET, umożliwiająca organizację, przeglądanie i uczestnictwo w różnego rodzaju wydarzeniach, takich jak konferencje, seminaria czy spotkania biznesowe. Platforma ma na celu ułatwienie procesu planowania i zarządzania wydarzeniami, zarówno dla organizatorów, jak i uczestników.

## Opis Funkcjonalności
1. **Rejestracja i Logowanie:** Użytkownicy mogą założyć konto poprzez rejestrację. Możliwość logowania się na istniejące konta.
2. **Dodawanie Wydarzeń:** Użytkownik może tworzyć wydarzenia, jako organizator dodać informacje takie jak tytuł, data, zdjęcie, lokalizacja itp., oraz edytować je i usuwać. Formularz dodawania wydarzenia z intuicyjnym interfejsem.
3. **Zainteresowanie Wydarzeniami:** Użytkownicy mogą wyrazić chęć uczestnictwa w wybranych wydarzeniach (jestem zainteresowany/a), po czym otrzymają potwierdzenie dodania wydarzenia do ich personalnej listy wydarzeń.
4. **Przeglądanie Wydarzeń:** Użytkownicy mają dostęp do przeglądu ogólnie dostępnych wydarzeń. Mogą wyszukiwać wydarzenia na podstawie różnych kryteriów oraz mieć dostęp do personalnej listy wydarzeń.

## Cel Projektu
Celem projektu EventHub jest stworzenie platformy, która ułatwi organizację i uczestnictwo w wydarzeniach, tworząc jednocześnie przyjazne środowisko dla użytkowników.

## Technologia
Projekt jest zrealizowany w technologii ASP.NET, zapewniającej solidną podstawę dla aplikacji internetowych opartych na architekturze klient-serwer.

## Jak uruchomić
1. Pobierz cały projekt z GitHuba w formacie .zip i wypakuj go na pulpicie.
2. Otwórz plik `eventHub.sln` przy pomocy programu Visual Studio.
3. W zakładce Narzędzia wybierz kolejno Menedżer pakietów NuGet i Konsola menedżera pakietów.
4. W konsoli wykonaj kolejno komendy:
    ```
    add-migration nazwa_migracji
    update-database
    ```
   O ile dodanie migracji może okazać się niepotrzebne, należy wykonać aktualizację bazy danych.
5. Uruchom projekt.

Projekt był sprawdzony przez kilka osób na różnych urządzeniach. Gdyby jednak pojawiły się problemy, prosimy o kontakt z twórcami przy pomocy Discorda.


