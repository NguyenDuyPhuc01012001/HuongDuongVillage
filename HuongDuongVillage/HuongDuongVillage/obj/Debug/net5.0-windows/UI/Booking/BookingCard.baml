   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5      .    (HuongDuongVillage.UI.Booking.BookingCard   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HuongDuongVillage     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $��50��5	      .��5      � .+�5   
   �� $��20,5,5,5q�5      
�������  �� CornerRadius$  10��5      ._�5      �  � ColumnDefinitions 5      �� 5      $	��110 �6'   �� 5      $��* �6'   �� 5      $	��150 �6'   �� 5      $	��150 �6'   �� 5      $	��150 �6'   �� 5      $	��145 �6'   .+�5      �� 
�������$��0,0,1,0q�6,   ._�5      �� -   5         ��Name$ tblRoomName��5      $
��10,0q�5      $��Center=�5      $��Center=�5      $��14(�5      
���   �$��	Phòng 1A��5!      5"      �� 5#      $��1��5$      
�������$��0,0,1,0q�5&      ._�5'      �� -   5        $ 
tblCusName��5(      $
��10,0q�5)      $
��Left=�5*      $��Center=�5+      $��14(�5,      
���   �$��Nguyễn Văn A��5.      5/      �� 50      $��2��51      
�������$��0,0,1,0q�53      ._�54      �� -   5        $ tblCusID��55      $
��10,0q�56      $��Center=�57      $��Center=�58      $��14(�59      
���   �$��	251213180��5;      5<      �� 5=      $��3��5>      
�������$��0,0,1,0q�5@      ._�5A      �� -   5        $ tblDateCheckIn��5B      $
��10,0q�5C      $��Center=�5D      $��Center=�5E      $��14(�5F      
���   �$��1/1/2021��5H      5I      �� 5J      $��4��5K      
�������$��0,0,1,0q�5M      ._�5N      �� -   5        $ tblDateCheckOut��5O      $
��10,0q�5P      $��Center=�5Q      $��Center=�5R      $��14(�5S      
���   �$��1/1/2022��5U      5V      � 5X      $��5��6   $��Center=�6'    5Y      �� 5Z      �� 5[      �� 5\      .+�5^      �� -   5         ��Name$ 
viewButton��5_      $��0��5`      $
��auto��5a      
�������
�������.��5g      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��viewIcon��5h      
�������   Kind$	 Eye=�5j      5k      �� 5l      $��1��5m      $��41��5n      $��20��5o      
������� � LayoutTransform 5q      �� 5r       �� Angle$ 90Q�6.   5t      �� 5u      -   5        $ deleteButton��5v      $��2��5w      $
��auto��5x      
�������
�������.��5~        -	   5          Name$ 
deleteIcon��5      
�������$ 
GarbageCan=�5�      5�      5�      5�      5�      5�      5�      