   M S B A M L   `   `   `  ����C  ?MVVN_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MVVN_WPF.ViewsMVVN_WPF.Views  5      (    "MVVN_WPF.Views.MakeReservationView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:MVVN_WPF.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    
  Header#��[  6!   $��Make Rservations��6A   � 5   
   $��1��6     5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $
��Name��6%   �� 5      $��1��6   $��0 5 0 0q�6#   ��64   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�5      � 5   
   $��2��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5       � $��0��6     5!      �� 5"      $
��auto �6$   �� 5#      $
��auto �6$   .+�5%      �� $��0��6   $��Floor No��6)   �� 5&      $��1��6   $��0 5 0 0q�6'   ��68   �� *FloorNumber+$ PropertyChanged=�5'      � 5(      $��1��6   $��15 0 0 0q�6#     5)      �� 5*      $
��auto �6$   �� 5+      $
��auto �6$   .+�5-      �� $��0��6   $��Room No��6)   �� 5.      $��1��6   $��0 5 0 0q�6'   ��68   �� *
RoomNumber+$ PropertyChanged=�5/      51      � 52   
   $��3��6    53      �� 54      $
��auto �6#   �� 55      $
��auto �6#   .+�57      � $��0��6     58      �� 59      $
��auto �6$   �� 5:      $
��auto �6$   .+�5<      �� $��0��6   $��
Start Date��6)   (  "System.Windows.Controls.DatePicker  5=      $��1��6   $��0 5 0 0q�6*      SelectedDate 6;   �� *	StartDate+$ PropertyChanged=�5>      � 5?      $��1��6   $��15 0 0 0q�6#     5@      �� 5A      $
��auto �6$   �� 5B      $
��auto �6$   .+�5D      �� $��0��6   $��End Date��6)     5E      $��1��6   $��0 5 0 0q�6*    6;   �� *	EndDate+$ PropertyChanged=�5F      5H      � 5I   
   $��4��6   $��0 20 0 0q�6    5J      �� 5K      $
��auto �6#   �� 5L      $
��auto �6#   .+�5N      �� $��0��6   $��0 0 10 0q�6%   $��5q�67   ��6C   �� *SubmitCommand+.��6e   Submit6m   �� 5O      $��1��6   $��10 0 0 0q�6%   $��5q�67   ��6C   �� *CancelCommand+.��6e   Cancel6m   5P      5Q      5R      