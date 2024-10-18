# Поведенческие паттерны
Решают задачи эффективного и безопасного взаимодействия между объектами программы.
1. Цепочка обязанностей (Chain of Responsibility)
2. Команда (Действие, Транзакция, Action, Command)
3. Итератор (Iterator)
4. Посредник (Mediator, Intermediary, Controller)
5. Хранитель (Memento, Снимок)
6. Наблюдатель (Издатель-Подписчик, Слушатель, Observer)
7. Состояние (State)
8. Стратегия (Strategy)
9. Шаблонный метод (Template Method)
10.Посетитель (Visitor)

- Инкапсуляция вариаций - элемент многих паттернов поведения. Если определенная часть программы подвержена периодическим изменениям, эти паттерны позволяют определить объект для инкапсуляции такого аспекта. Другие части программы, зависящие от данного аспекта, могут кооперироваться с ним. Обычно паттерны поведения определяют абстрактный класс, с помощью которого описывается инкапсулирующий объект. Своим названием паттерн обязан этому объекту.
- Объект <b>стратегия</b> инкапсулирует алгоритм.
- Объект <b>состояние</b> инкапсулирует поведение, зависящее от состояния.
- Объект <b>посредник</b> инкапсулирует протокол общения между объектами.
- Объект <b>итератор</b> инкапсулирует способ доступа и обхода компонентов составного объекта.

## Задание:
1. В библиотеке текстовых псевдоокон совместите реализации Цепочки обязанностей и Наблюдателя, используя код из примера.
2. Сделайте выгрузку графической сцены используя Посетителя в формате XML
