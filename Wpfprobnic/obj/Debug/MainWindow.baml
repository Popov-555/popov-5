   M S B A M L   `   `   `  ����E  AWpfprobnic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfMedWpfMed  5   	       WpfMed.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfMed     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �  � ShowGridLines .  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      �� 5      $��50 �6     � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      .+�5      ��  �� Orientation$ Vertical=�5   	   $��3��5   	   $��Bottom=�5   	   .+�5      �� -   5         ��Name$ 
ExitButton��5      $��
Выход��5       $��50��5"      5#      &   System.Windows.Controls.DataGrid  5$      $��1��5%      $��1��5&         CanUserAddRows .     AutoGenerateColumns .  ��5)      �� *	YearAList+   Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Название��5,      1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5-      �� *Name+  5.      $	 
Автор��5/      
 50      �� *Avtor+  51      $	 Издательство��52      
 53      �� *Izdatelstvo+  54      $	 Год��55      
 56      �� *Year+  57      $	 Количество��58      
 59      �� *Kolichestvo+5=      � 5>       � Orientation$ 
Horizontal=�5?   	   $��1��5@   	   $��50��5A   	   .+�5B      �� $��Год:��5C      $��Center=�5D      �� 5F      -   5        $��NameFilterComboBox��5G      $��Center=�5I      $	��100��5J       �� SelectedIndex$ 0��5K      ��5L      �� *	YearAList+��5N      �� 5O      .R�5P      �� ��5Q      �� *Title+5R      5T      �� 5U      $��
Поиск��5V      $��Center=�5W      �� 5X      -   5         ��Name$ SearchFilterTextBox��5[      $	��100��5Y      $��Center=�5Z      5\      �� 5]      $��Сортировка:��5^      $��Center=�5_      	� 5`      -   5         	� 	GroupName$	 Age��5a      
 � Tag$ 1��5b      $!��По возрастанию��5c       d� 	IsChecked$
 TrueY�5d      $��Center=�5f      	� 5g      -   5        $	 Age��5h      $ 2��5i      $��По убыванию��5j      $��Center=�5l      5m      5n      5o      5p      