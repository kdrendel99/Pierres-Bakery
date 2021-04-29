# _Pierre's Bakery_

#### _This application uses C# and dotnet to create an order form for the user in a console-based application._

#### _By **Karlson Drendel**_

#### _Table of Contents_

1. [Preview](#preview)
2. [Technologies Used](#technologies)
3. [Description](#description)
4. [Setup/Installation Requirements](#setup)
5. [Additional Setup/Installation Note for Windows Users](#windows)
6. [Specifications](#specs)
7. [Known Bugs](#bugs)
8. [License](#license)
9. [Contact Information](#contact)

## Preview <a id="preview"></a>

* _Direct your browser to a [live version](kdrendel99.github.io/project/index.html) on GitHub Pages._

## Technologies Used <a id="technologies"></a>

* _C# 8.0_
* _.NET 5 Framework_
* _Microsoft Visual Studio Code_

## Description <a id="description"></a>

_Collect user input in a console-based application in order to perform calculations including discounts, final cost, and imput validation. This application was build to practice using C# Object Orientation and Test-Driven Development._


## Setup/Installation Requirements <a id="setup"></a>

* _Open terminal._

* _Install Microsoft .NET Version 5._

* _Clone this project with the following git command `$ git clone https://github.com/kdrendel99/Pierres-Bakery.git`_

* _Open project using your preferred code editor._

* _Navigate to PierresBakery.Tests_

* _Enter 'dotnet restore' into terminal and press enter_

* _To confirm project tests are still passing, enter dotnet test into the terminal in current directory._

* _Navigate back to Pierres-Bakery.Solutions, and enter dotnet build in the terminal. Press enter._

* _Navigate into PierresBakery, and enter 'dotnet run' into terminal, and run the project._



## Known Bugs <a id="bugs"></a>
* _After invalid inputs are entered, the project navigates the user back to the top of the Main() method. Doing so doesn't clear the memory caches, and if the user continues to run the project until checkout, the first "order" (even if empty) will also appear in the order summary._


## License <a id="license"></a>

*_Copyright <2021> Karlson Drendel_

*_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._


*[MIT](https://choosealicense.com/licenses/mit/)*

Copyright (c) **_2021 Karlson Drendel_**

## Contact Information <a id="contact"></a>
**_Karlson Drendel kdrendel99@gmail.com_**










PIERRE'S BAKERY
Create a C# console application for a bakery that includes the following functionality:

There should be two classes: one for Bread and one for Pastry.

When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.

A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.

The application will return the total cost of the order.

Pierre offers the following deals:

Bread: Buy 2, get 1 free. A single loaf costs $5.
Pastry: Buy 1 for \$2 or 3 for $5.
All functionality for the models should be tested.

OBJECTIVES
Your code will be reviewed for the following objectives:

Code includes two custom classes and uses namespaces.
Console application works correctly.
Application correctly uses auto-implemented properties.
Classes should include methods for determining the price of an order.
Models are thoroughly tested.
Previous objectives have been met.
Required functionality is in place by the deadline.
Project is in a polished, portfolio-quality state.
Project demonstrates understanding of this week's concepts. If prompted, you can discuss your code with an instructor using the correct terminology.