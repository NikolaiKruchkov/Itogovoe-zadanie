   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5   	   =#clr-namespace:Calculator.ViewModelsCalculator.ViewModels  5   	       Calculator.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Calculator     5   	   2vm#clr-namespace:Calculator.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��600��6   $	��600��6)    � 
ResizeMode$ NoResize=�5
   	   
������� � DataContext 5      /  )Calculator.ViewModels.MainWindowViewModel  5   
    J� InputBindings 5      �� 5   
   
 �� Key$ NumPad1��62    �� Command 6   ��  �� Path$	 One�62   �� 5   
   $ NumPad2��62    6   �� $	 Two�62   �� 5   
   $ NumPad3��64    6   �� $ Three�64   �� 5   
   $ NumPad4��63    6   �� $
 Four�63   �� 5   
   $ NumPad5��63    6   �� $
 Five�63   �� 5   
   $ NumPad6��62    6   �� $	 Six�62   �� 5   
   $ NumPad7��64    6   �� $ Seven�64   �� 5   
   $ NumPad8��64    6   �� $ Eight�64   �� 5   
   $ NumPad9��63    6   �� $
 Nine�63   �� 5   
   $ NumPad0��63    6   �� $
 Zero�63   �� 5   
   $ Decimal��68    6   �� $ 	Zapyataya�68   �� 5   
   $	 Add��63    6   �� $
 Plus�63   �� 5   
   $ Subtract��64    6   �� $ Minus�64   �� 5   
   $ Multiply��66    6   �� $ Umnogit�66   �� 5   
   $ Divide��67    6   �� $ Razdelit�67   �� 5   
   $ Enter��64    6   �� $ Ravno�64   �� 5   
    �� 	Modifiers$
 Ctrlf�63   $ X��6D    6   �� $
 Exit�6D   �� 5    
   $
 Ctrlf�63   $ C��6D    6   �� $
 Copy�6D   �� 5!   
   $
 Ctrlf�64   $ V��6E    6   �� $ Paste�6E   �� 5"   
   $ F1��66    6   �� $ Spravka�66   .��5$      �� .+�5%   
   o� .@�5&      m� $��Файл��6   .@�5'      m� $��
Выход��6    m� InputGestureText$ CTRL+X��6H   	 m� Command	 6*   �� $
 Exit�6H   5(      m� 5)      $��Правка��6   .@�5*      m� $��Копировать��6   $ CTRL+C��6M   	 6/   �� $
 Copy�6M   m� 5+      $��Вставить��6   $ CTRL+V��6L   	 6-   �� $ Paste�6L   5,      5-      �� 5.   
   $	��100��6   ��6   �� $ 	Znachenie�� 5/   
   $��5q�6   $	��400��6   
 � ColumnDefinitions
 50      �� 51      �� 52      �� 53      �� 54      �� 55      �� 56       � RowDefinitions 58      �� 59      �� 5:      �� 5;      �� 5<      �� 5=      .+�5?      �� $��%��6   ��6!   �� $ Procent��� 5@      $��1��6   $��0��6%   $	��+/-��62   ��6@   �� $ 	PlusMinus��� 5A      $��2��6   $��0��6%   $��C��62   ��6>   �� $ Clear��� 5B      $��3��6   $��0��6%   $	��DEL��62   ��6@   �� $ Delete��� 5C      $��4��6   $��0��6%   $��/��62   ��6>   �� $ Razdelit��� 5D      $��5��6   $��0��6%   $��*��62   ��6>   �� $ Umnogit��� 5E      $��0��6   $��1��6%   $	��√��62   ��6>   �� $ Qoren��� 5F      $��1��6   $��1��6%   $	��X²��62   ��6?   �� $ Qvadrat��� 5G      $��2��6   $��1��6%   $��7��62   ��6>   �� $ Seven��� 5H      $��3��6   $��1��6%   $��8��62   ��6>   �� $ Eight��� 5I      $��4��6   $��1��6%   $��9��62   ��6>   �� $
 Nine��� 5J      $��5��6   $��1��6%   $��-��62   ��6>   �� $ Minus��� 5K      $��0��6   $��2��6%   $	��1/X��62   ��6@   �� $ Delenie1��� 5L      $��1��6   $��2��6%   $	��x^y��62   ��6@   �� $ Stepen��� 5M      $��2��6   $��2��6%   $��4��62   ��6>   �� $
 Four��� 5N      $��3��6   $��2��6%   $��5��62   ��6>   �� $
 Five��� 5O      $��4��6   $��2��6%   $��6��62   ��6>   �� $	 Six��� 5P      $��5��6   $��2��6%   $��+��62   ��6>   �� $
 Plus��� 5Q      $��0��6   $��3��6%   $��π��62   ��6>   �� $ Pi��� 5R      $��1��6   $��3��6%   $	��2ˣ��62   ��6?   �� $ 
DvaVStepen��� 5S      $��2��6   $��3��6%   $��1��62   ��6>   �� $	 One��� 5T      $��3��6   $��3��6%   $��2��62   ��6>   �� $	 Two��� 5U      $��4��6   $��3��6%   $��3��62   ��6>   �� $ Three��� 5V      $��5��6   $��3��6%   $��2��62   $��=��6C   ��6O   �� $ Ravno��� 5W      $��0��6   $��4��6%   $��e��62   ��6>   �� $ Exponent��� 5X      $��1��6   $��4��6%   $	��eˣ��62   ��6?   �� $ ExponentStepen��� 5Y      $��2��6   $��4��6%   $��2��62   $��0��6F   ��6R   �� $
 Zero��� 5Z      $��4��6   $��4��6%   $��.��62   ��6>   �� $ 	Zapyataya�5[      �� 5\   
   $8��2Для вызова справки нажите F1��6   $��40��67   5]      5^      