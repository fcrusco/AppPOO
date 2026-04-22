Este projeto é uma revisão prática dos pilares da **Programação Orientada a Objetos (POO)** e **Injeção de Dependência** em C#, simulando um motor de cálculo de fretes logísticos para fins educacionais.

---

### 💡 Conceitos Aplicados
* **Abstração e Interfaces:** Uso de `IFreteService` para definir contratos de serviço, desacoplando a lógica de quem a consome.
* **Herança:** `FreteExpresso` e `FreteEconomico` herdam de uma classe base comum (`FreteBase`).
* **Classe Abstrata:** `FreteBase` serve como um molde que não pode ser instanciado, garantindo que todo frete tenha um comportamento padrão.
* **Polimorfismo:** O método `Calcular` é sobrescrito (`override`) para aplicar regras específicas conforme a modalidade.
* **Encapsulamento:** Uso do modificador `protected` e propriedades somente leitura para proteger constantes de negócio.
* **Injeção de Dependência (DI):** A classe `CalculadoraLogistica` recebe sua dependência via construtor, facilitando a manutenção e testes.
* **Classes Estáticas:** Implementação de utilitário (`FormataMoeda`) para padronização visual.

### 🏗️ Estrutura do Projeto
* `Interface/`: Contratos de serviço (`IFreteService`).
* `Model/`: Classes de domínio, base abstrata e lógicas de cálculo.
* `Service/`: Orquestração de negócio (`CalculadoraLogistica`).
* `Util/`: Helpers e formatação.

---

## 🇺🇸 English

### 💡 Concepts Applied
* **Abstraction & Interfaces:** Using `IFreteService` to define service contracts and decoupling logic.
* **Inheritance:** `FreteExpresso` and `FreteEconomico` inherit from a common base class (`FreteBase`).
* **Abstract Class:** `FreteBase` acts as a template that cannot be instantiated, ensuring all freight types follow a standard behavior.
* **Polymorphism:** The `Calcular` (Calculate) method is overridden to provide specific logic for each shipping modality.
* **Encapsulation:** Using `protected` modifiers and read-only properties to secure business rules.
* **Dependency Injection (DI):** `CalculadoraLogistica` receives its dependencies through the constructor, ensuring low coupling.
* **Static Classes:** Utility implementation (`FormataMoeda`) for visual standardization.

### 🏗️ Project Structure
* `Interface/`: Service contracts.
* `Model/`: Domain classes and calculation logic.
* `Service/`: Business logic orchestration.
* `Util/`: Helpers and utilities.

---

## 🇪🇸 Español

### 💡 Conceptos Aplicados
* **Abstracción e Interfaces:** Uso de `IFreteService` para definir contratos de servicio y desacoplar la lógica.
* **Herencia:** `FreteExpresso` y `FreteEconomico` heredan de una clase base común (`FreteBase`).
* **Clase Abstracta:** `FreteBase` actúa como una plantilla que no puede instanciarse, asegurando que todos los fletes sigan un comportamiento estándar.
* **Polimorfismo:** El método `Calcular` se sobrescribe para aplicar reglas específicas según la modalidad.
* **Encapsulamiento:** Uso del modificador `protected` y propiedades de solo lectura para proteger las reglas de negocio.
* **Inyección de Dependencias (DI):** La clase `CalculadoraLogistica` recibe su dependencia a través del constructor.
* **Clases Estáticas:** Implementación de utilidad (`FormataMoeda`) para la estandarización visual.

### 🏗️ Estructura del Proyecto
* `Interface/`: Contratos de servicio.
* `Model/`: Clases de dominio y lógica de cálculo.
* `Service/`: Orquestación y lógica de negocio.
* `Util/`: Helpers y utilidades.

---

## 🛠️ Tecnologias / Technologies / Tecnologías
* C# (.NET 8.0+)

