   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      F BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TaskManagerTaskManager 5      =#clr-namespace:TaskManager.ViewModelTaskManager.ViewModel 5      5clr-namespace:TaskManager.ModelTaskManager.Model 5	      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5      *   $TaskManager.View.TaskManagerMainView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5      +localclr-namespace:TaskManager     5      9	viewModel#clr-namespace:TaskManager.ViewModel     5      0dataclr-namespace:TaskManager.Model     5	      4model"clr-namespace=Model;assembly=Model     5
      einteractPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      7core&using:Microsoft.Xaml.Interactions.Core     5      <interactivity"using:Microsoft.Xaml.Interactivity     5        � DataContext  5      0 *TaskManager.ViewModel.AddEditTaskViewModel  5   
    � 	Resources 5       �� DataType$  TaskManager.Model.EditableTask �Name � ColumnDefinitions ��Name �� Path �� Mode �� UpdateSourceTrigger(  "System.Windows.Controls.DatePicker	  Name
   SelectedDate ��Name d� 	IsChecked �� Triggers �� Value �� Binding �� 
TargetName �� Property �� Value��%]  (��       5      *, +)�� 6
   "  6   .R�5      � $ taskItem��6   
������� 5      �� 5       $��* �6'   �� 5!      $
��Auto �6'   �� 5"      $
��Auto �6'   .+�5%      �� $ 	TaskDescr��6}   $��0��6   ��6,   �� $ TaskInfo�$ TwoWay=�$ PropertyChanged=�6}     5&      $	 DueDate��6�   $��1��6   
 6-   �� $ TaskDueDate�$ TwoWay=�$ PropertyChanged=�6�   �� 5'      $ TaskComplete��6�   $��2��6    6+   �� $ TaskIsComplete�$ TwoWay=�$ PropertyChanged=�6�   5*       5,      �� 5-      $ TaskIsOverdue��6t    6   �� $ 
TaskStatus�$ OneWay=�$ PropertyChanged=�.a�5.      �� $ taskItem��6    � ��
 �  ��6J   5/      �� 51      $ TaskIsComplete��6t    6   �� $ 
TaskStatus�$ OneWay=�$ PropertyChanged=�.a�52      �� $ taskItem��6    � ��
 � � �6J   53      �� 55      $ TaskIsInProgress��6u    6   �� $ 
TaskStatus�$ OneWay=�$ PropertyChanged=�.a�56      �� $ taskItem��6    � ��
 �����6J   57      5;      5?      .��5A      �  � RowDefinitions 5B   
   �� 5C      $
��Auto �6   �� 5D      $
��Auto �6   �� 5E       5G   
   �� 5H      �� 5I      $
��Auto �6   �� 5J      $
��Auto �6   .+�5N   
   o� $��0��6   $��0��6   $��3��6,   .@�5O      m� $��_File��6   .@�5P      m� $��	_New task��6   m� 5Q      $��_Exit��6   5R      m� 5T      $��_Date��6   5W      �� 5Y   
   -   5        $��
todaysDate��5Y   -   $��0��6   $��1��6   6-   �� 5[   
   -   5        $��taskInfo��5[      $��1��5\      $��0��5]      $��5q�5^      ��5_      �� *NewTask.TaskInfo+$ TwoWay=�$ PropertyChanged=�  5c   
   -   5        $��dueDate��5f      $��1��5c      $��1��5d      $��5q�5e      $|�False��5g      
 �� Now   DisplayDate# Z 5h      
 5i      �� *NewTask.TaskDueDate+$ TwoWay=�$ PropertyChanged=��� 5l   
   $	��Add��6   $��1��5n      $��2��5o      $��5q�5p      ��5m      �� *
AddCommand+5p      �� 5u   
   -   5         ��Name$ ListBoxTasks��5v      $��Stretch=�6'   $��2��5w      $��2��6   $��0��6/   $��3��6?   $��5q�6S   ��5x      �� *Tasks+$ TwoWay=�5|      5      5�      