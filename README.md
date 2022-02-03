# MTTPP - projekt

Projekt sadrži 6 test caseova:
* Login test
* Register test
* Change password test
* Check product test
* Add ptoduct to wish list test
* Add product to cart

Testiranje se izvodilo na [demo](https://demo.opencart.com/) stranici u C# jeziku.
___

## Koraci za izvođenje testa

1. Skinuti Visual Studio (u mom slučaju to je Visual Studio 2017)
2. Skinuti preglednike [Chrome](https://www.google.com/chrome/?brand=BNSD&gclid=CjwKCAiAl-6PBhBCEiwAc2GOVOSiJs6dJGbigW5BcB1m_fl6wMU9rH_xbtAlN-loKmx3Cigaey4UfhoCbD4QAvD_BwE&gclsrc=aw.ds) i [Firefox](https://www.mozilla.org/hr/firefox/new/)
3. Skinuti [chromedriver](https://chromedriver.chromium.org/downloads) i staviti ga u odabranu mapu. Driver mora biti iste verzije kao Vaš Chrome preglednik da testiranje ispravno radi. Ako želite pokrenuti moje testove driver postavite u mapu **Drivers** na **C disku**
4. Kreirati novi projekt u Visual Studiu: 
**File -> New -> Project -> Templates -> Visual C# -> Test -> Unit Test Project**
5. Putem **Project -> Manage NuGet Packages** dodati:
    * NUnit framework
    * Selenium WebDriver
    * Selenium Support
    * Nunit3 Test Adapter
    * Selenium WebDriver – Gecko Driver
    * MSTest.TestFramework
    * MSTest.TestAdapter
    * DotNetSeleniumExtras.WaitHelpers
6. Možete krenuti pisati testove!
7. Napisane testove možete pokrenuti u Test Exploreru. Ako vać nije uključen to možete odratiti: **Test-> Windows-> Test Explorer**

Ako želite pokrenuti moje testove dovoljno je da skinete repozitorij i pokrenete .sln datoteku.
___

## Informacije o testu

Test caseove je moguće pokrenuti u Chromeu i Firefoxu. Test je napravljen pomoću Page Object Modela gdje su naredbe za testove raspoređene po stranicama na kojima se trenutno nalazimo, primjerice: ako se nalazimo na početnoj stranici aplikacije i želimo nešto na njoj kliknuti, ta se naredba nalazi u klasi MainPage u mapi Pages.
<br>

Primjer jedne klase u mapi Pages:
<br>
```C#
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    class AccountPage : SetUpDriver
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

        public void ClickPasswordOption() {
            IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("Password")));
            webElement.Click();
        }
    }
}
```
Morate biti pažljivi kod Login, Register i Cahange Passwprd testova jer se lozinke mijenjaju pa je moguće da prijava na bude uspješna. Ako želite uspješne testove morate postaviti **drugačiji** E-mail i lozinku!
