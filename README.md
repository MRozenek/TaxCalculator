# TaxCalculator
Hipotetycny program do naliczania podatku od wynagrodzeñ.
## Technologia
* u¿yto .net standard dla projektu gównego (dll) oraz .net core dla projektu testowego. W moim przypoadku to pierwsze u¿ycie .net standard/core, zapoznanie siê z zast¹pieniem plików App.Config poptzrz AppSettings.json. Nie sprawdza³em zastosowania w ró¿nych systemach operacyjnych.
* u¿ycie w.w. plików konfiguracyjnych celem ³atwej rekonfiguracji ustawieñ biblioteki np. stawki podatkowej z 17% na 18%
## Szczegó³y
* gówna metoda CalculateTax posiada interfejs: decimal CalculateTax(TaxCalculationDetails[] income, TaxMethodType taxMethodType) 
* gówna metoda CalculateTax pod¹¿a za koncepcj¹ OCP i poprzez wykorzystanie abstrakcji BaseTaxMethodTypeCalculator oraz fabryki TaxMethodTypeCalculatorFactory nie ma potrzeby ingerowania w klasê TaxCalculator, co czyni zmiany i testy bardziej komfortowymi, zak³adamy ¿e TaxMethodType jest g³ówn¹ osi¹ zmian (axis of change)
## Problemy
* przypdaek testowy ostani "Kolejne wynagrodzenie w tym roku w wysokoœci 100000 z³otych" daje b³êdne rezultaty. Wynik to 20245, z dokumantacji oczekiwane jest 19920. Do wyjaœnienia.