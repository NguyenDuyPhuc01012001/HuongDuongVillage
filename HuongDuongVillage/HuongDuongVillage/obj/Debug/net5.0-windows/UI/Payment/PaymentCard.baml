   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5      #    HuongDuongVillage.PaymentCard   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HuongDuongVillage     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $��50��5	      .��5
      � .+�5   
   �� $��	20,5,25,5q�5      
�������  �� CornerRadius$  10��5      ._�5      �  � ColumnDefinitions 5      �� 5      $��65 �6'   �� 5      $	��250 �6'   �� 5      $	��170 �6'   �� 5      $	��200 �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� 
�������$��0,0,1,0q�6,   ._�5      �� -   5         ��Name$  employeeBasicInfoContainer��5      $��Center=�5      $��0��5      $	��5,0q�5       �� Orientation$ 
Horizontal=�5      .+�5      �� -   5         ��Name$ idTxb��5       $��Center=�5!      $��Center=�5"      
���   �$��14(�5$      $��1��5%      5&      5'      �� 5(      
�������$��1��6,   $��0,0,1,0q�6<   ._�5)      �� -   5        $ employeeSalaryContainer��5*      $��1��5+      $��5q�5,      $ 
Horizontal=�5-      .+�5.      �� -   5        $ 
cusNameTxb��5/      $��Center=�50      $��Center=�51      
���   �$��14(�53      $��Nguyen Doan Thinh��54      55      56      �� 57      
�������$��2��6,   $��0,0,1,0q�6<   ._�58      �� -   5        $��employeeRole��59      $��2��5:      $��5q�5;      $��Center=�5<      $ 
Horizontal=�5=      .+�5>      �� -   5        $ 	amountTxb��5?      $��Center=�5@      $��Center=�5A      $��14(�5B      
���   �$��	100000000��5D      5E      5F      �� 5G      
�������$��3��6,   $��0,0,1,0q�6<   ._�5H      �� -   5        $��employeeMail��5I      $��Center=�5J      $��3��5K      $��5q�5L      $ 
Horizontal=�5M      .+�5N      �� -   5        $ paymentDateTxb��5O      $��Center=�5P      $��Center=�5Q      
���   �$��14(�5S      $��	19/2/2021��5T      5U      5V      �� 5W      
�������$��4��6,   $��0,0,1,0q�6<   ._�5X      �� -	   5        $��employeePhone��5Y      $��4��5Z      $��5q�5[      $��Center=�5\      $ 
Horizontal=�5]      .+�5^      �� -
   5        $ paymentMethodTxb��5_      $��Center=�5`      $��Center=�5a      
���   �$��14(�5c      $��Master card��5d      5e      5f      �� 5g      $��Center=�6   $��Center=�6:   $��5��6U   .+�5h      �� -   5         ��Name$ deleteButton��5i      $��Center=�5j      $��1��5k      
�������
�������.��5p      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ 
deleteIcon��5q      
�������   Kind$ 
GarbageCan=�5s      5t      5u      5v      5w      5x      5y      