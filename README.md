# TaxCalculator
Hipotetycny program do naliczania podatku od wynagrodze�.
## Technologia
* u�yto .net standard dla projektu g�wnego (dll) oraz .net core dla projektu testowego. W moim przypoadku to pierwsze u�ycie .net standard/core, zapoznanie si� z zast�pieniem plik�w App.Config poptzrz AppSettings.json. Nie sprawdza�em zastosowania w r�nych systemach operacyjnych.
* u�ycie w.w. plik�w konfiguracyjnych celem �atwej rekonfiguracji ustawie� biblioteki np. stawki podatkowej z 17% na 18%
## Szczeg�y
* g�wna metoda CalculateTax posiada interfejs: decimal CalculateTax(TaxCalculationDetails[] income, TaxMethodType taxMethodType) 
* g�wna metoda CalculateTax pod��a za koncepcj� OCP i poprzez wykorzystanie abstrakcji BaseTaxMethodTypeCalculator oraz fabryki TaxMethodTypeCalculatorFactory nie ma potrzeby ingerowania w klas� TaxCalculator, co czyni zmiany i testy bardziej komfortowymi, zak�adamy �e TaxMethodType jest g��wn� osi� zmian (axis of change)
## Problemy
* przypdaek testowy ostani "Kolejne wynagrodzenie w tym roku w wysoko�ci 100000 z�otych" daje b��dne rezultaty. Wynik to 20245, z dokumantacji oczekiwane jest 19920. Do wyja�nienia.