   M S B A M L   `   `   `  ����G  CTask Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Task_Manager.ViewsTask_Manager.Views  5      ?$clr-namespace:Task_Manager.ViewModelTask_Manager.ViewModel  5      7 clr-namespace:Task_Manager.ModelTask_Manager.Model  5      3clr-namespace:Task_Manager.VMLTask_Manager.VML  5	      !    Task_Manager.Views.TaskView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Task_Manager.Views     5      :	viewModel$clr-namespace:Task_Manager.ViewModel     5      1data clr-namespace:Task_Manager.Model     5      .vmlclr-namespace:Task_Manager.VML     5	      '   !Task_Manager.VML.ViewModelLocator    AutoHookedUpViewModel$
  True��5
       � 	Resources 5       �� DataType   Task_Manager.Model.Task � ColumnDefinitions ��Name �� Mode(  "System.Windows.Controls.DatePicker  Name   SelectedDate ��Name	 d� 	IsChecked
 �� UpdateSourceTrigger��%�  (��       5      *, +)�� 6
   "  6   .R�5      �  5      �� 5      $��* �6'   �� 5      $
��Auto �6'   �� 5      $
��Auto �6'   .+�5      �� $ 	TaskDescr��6Z   $��0��6   ��6,   �� *taskDescription+$ TwoWay=�6Z     5      $ DueDate��6_   $��1��6    6-   �� *taskDueDate+$ TwoWay=�6_   �� 5      $ TaskComplete��6~   $��2��6   	 6+   �� *
isComplete+$ TwoWay=�$
 PropertyChanged=�6~   5      5      5      .��5      �  � RowDefinitions 5    
   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#       5%   
   �� 5&      �� 5'      $
��Auto �6   �� 5(      $
��Auto �6   .+�5,   
   o� $��0��6   $��0��6   $��3��6,   .@�5-      m� $��_File��6   .@�5.      m� $��	_New task��6   m� 5/      $��_Exit��6   50      m� 52      $��_Date��6   54      55      �� 57   
   -   5        $��
todaysDate��57   -   $��0��6   $��1��6   6-   �� 59   
   -   5        $��taskInfo��59   :   $��1��6   $��0��6   $��5q�6/   6:     5;   
   -   5        $��dueDate��5;   =   $��1��6   $��1��6"   $��5q�62   6=   �� 5=   
   $��1��6   $��2��6   $��5q�6.   .��69   Add6@   �� 5@   
   -   5        $��lbTasks��5A      $��Stretch=�6    $��2��5B      $��2��6   $��0��6/   $��3��6?   $��5q�6S   ��5C      �� *Tasks+5E      5H      