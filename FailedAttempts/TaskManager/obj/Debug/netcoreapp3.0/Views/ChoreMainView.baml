   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      F BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TaskManager.ViewModelsTaskManager.ViewModels 5      7 clr-namespace:TaskManager.ModelsTaskManager.Models 5      5clr-namespace:TaskManager.ViewsTaskManager.Views 5	      %   TaskManager.Views.ChoreMainView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5      :	viewModel$clr-namespace:TaskManager.ViewModels     5      1data clr-namespace:TaskManager.Models     5      1localclr-namespace:TaskManager.Views     5	        � 	Resources  5       �� DataType'  !TaskManager.Models.ChoreEditModel � ColumnDefinitions ��Name �� Mode(  "System.Windows.Controls.DatePicker  Name   SelectedDate ��Name d� 	IsChecked	 �� UpdateSourceTrigger��%�  (��       5      *, +)�� 6
   "  6   .R�5      �  5      �� 5      $��* �6'   �� 5      $
��Auto �6'   �� 5      $
��Auto �6'   .+�5      �� $ 	TaskDescr��6V   $��0��6   ��6,   �� *TaskDetails+$ TwoWay=�6V     5      $ DueDate��6_   $��1��6    6-   �� *TaskDateDue+$ TwoWay=�6_   �� 5      $ TaskComplete��6~   $��2��6    6+   �� *
TaskIsDone+$ TwoWay=�$	 PropertyChanged=�6~   5      5      5      .��5       � -   5        
 �Name$
 mainGrid��5        � DataContext 5!      �� *Chore+ � RowDefinitions 5"   
   �� 5#      $
��Auto �6   �� 5$      $
��Auto �6   �� 5%       5'   
   �� 5(      �� 5)      $
��Auto �6   �� 5*      $
��Auto �6   .+�5.   
   o� $��0��6   $��0��6   $��3��6,   .@�5/      m� $��_File��6   .@�50      m� $��	_New task��6   m� 51      $��_Exit��6   52      m� 54      $��_Date��6   56      57      �� 59   
   -   5        $��
todaysDate��59   -   $��0��6   $��1��6   6-   �� 5;   
   -   5        $��taskInfo��5>      $��1��5;      $��0��5<      $��5q�5=      $;��5 Binding IsFilled, ValidatesOnNotifyDataErrors = True��5?        5A   
   -   5        $��dueDate��5D      $��1��5A      $��1��5B      $��5q�5C      
 �� Now# Z 5E         Text$A ; Binding IsDateSelected, ValidatesOnNotifyDataErrors = True��5F      �� 5H   
   $��1��62   $��2��6?   $��5q�6O   ��6   �� *
AddCommand+.��6[   Add6`   �� 5K   
   -   5        $��lbTasks��5L      $��Stretch=�6    $��2��5M      $��2��6   $��0��6/   $��3��6?   $��5q�6S   ��5N      �� *Chores+5R      5V      