# TaxCalculator
Hipotetycny program do naliczania podatku od wynagrodze?.
## Technologia
* u?yto .net standard dla projektu g?wnego (dll) oraz .net core dla projektu testowego. W moim przypoadku to pierwsze u?ycie .net standard/core, zapoznanie si? z zast?pieniem plik?w App.Config poptzrz AppSettings.json. Nie sprawdza?em zastosowania w r??nych systemach operacyjnych.
* u?ycie w.w. plik?w konfiguracyjnych celem ?atwej rekonfiguracji ustawie? biblioteki np. stawki podatkowej z 17% na 18%
## Szczeg??y
* g?wna metoda CalculateTaxIncome posiada interfejs: decimal CalculateTaxIncome(TaxCalculationDetails[] income, TaxAccountingMethodType methodType) 
* g?wna metoda CalculateTaxIncome mog?a by wykorzystywa? lepiej koncepcje SOLID w szczeg?lno?ci OCP (ew. ToDo)
## Problemy
* przypdaek testowy ostani "Kolejne wynagrodzenie w tym roku w wysoko?ci 100000 z?otych" daje b??dne rezultaty. Wynik to 20245, z dokumantacji oczekiwane jest 19920. Do wyja?nienia.