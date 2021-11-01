# dotnet_Task_04_13
## Классы
### ComputerWebFirstLevel
Список полей:
- string name - Название организации; 
- int stantions_count - Число рабочих станций;
- int average_distance - Среднее расстояние между станциями в метрах.
* int calculate_quality() - метод для подсчёта параметра качества.

      Формула: Q = average_distance * stantions_count

---
  
### ComputerWebSecondLevel : ComputerWebFirstLevel
Список полей:
- string name - Название организации; 
- int stantions_count - Число рабочих станций;
- int average_distance - Среднее расстояние между станциями в метрах.
- int average_data_moving_speed - Cредняя скорость передачи данных в сети в Мбайт\с
* int calculate_quality() - метод для подсчёта параметра качества.

      Формула: Qp = Q * average_data_moving_speed
