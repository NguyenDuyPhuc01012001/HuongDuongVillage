   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5      !    HuongDuongVillage.StaffCard   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HuongDuongVillage     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $��50��5	      .��5      � .+�5   
   �� $��20 5 5 5q�5      
�������  �� CornerRadius$  10��5      ._�5      �  � ColumnDefinitions 5      �� 5      $��50 �6'   �� 5      $��2* �6'   �� 5      $	��120 �6'   �� 5      $��80 �6'   �� 5      $��2* �6'   �� 5      $��* �6'   �� 5      $	��145 �6'   .+�5      �� 
�������$��0,0,1,0q�6,   ._�5      �� -   5         ��Name$ tblID��5      $
��15,0q�5      $��Center=�5      $��Center=�5       $��14(�5!      
���   �$��1��5#      5$      �� 5%      $��1��6   
�������$��0,0,1,0q�6<   ._�5&      �� -   5        $ tblName��5(       �� Padding$ 5q�5'      $��Center=�5)      
���   �$��14(�5+      $��Nguyen Doan Thinh��5,      5-      �� 5.      $��2��6   
�������$��0,0,1,0q�6<   ._�5/      �� -   5        $ tblDOB��50      $��Center=�51      $��Center=�52      
���   �$��14(�54      $��
05/12/2001��55      56      �� 58      $��5,0,0,0q�6   $��3��6*   
�������$��0,0,1,0q�6M   ._�59      �� -   5        $ 	tblGender��5:      $��Center=�5;      $��Center=�5<      
���   �$��14(�5>      $
��Male��5?      5@      �� 5A      $��5,0,0,0q�6   $��4��6*   
�������$��0,0,1,0q�6M   ._�5B      �� -   5        $ tblMail��5C      $��Center=�5D      
���   �$��14(�5F      $��19522281@gm.uit.edu.vn��5G      5H      �� 5I      $��5,0,0,0q�6   $��5��6*   
�������$��0,0,1,0q�6M   ._�5J      �� -   5        $ tblRole��5K      $��Center=�5L      
���   �$��14(�5N      $	��CEO��5O      5P      �� 5Q      $��6��6   ._�5R      � $��Center=�6    5S      �� 5T      �� 5U      �� 5V      .+�5X      �� -   5         ��Name$ 
editButton��5Y      $��0��5Z      $
��auto��5[      
�������
�������.��5`      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��addIcon��5a      
�������   Kind$ Pencil=�5c      5d      �� 5e      $��1��5f      $��41��5g      $��20��5h      
������� � LayoutTransform 5j      �� 5k   "    �� Angle$ 90Q�62   5m      �� 5n      -	   5        $ deleteButton��5o      $��2��5p      
�������
�������$
��auto��5s      .��5v        -
   5          Name$ 
deleteIcon��5w      
�������$ 
GarbageCan=�5y      5z      5{      5|      5}      5~      5      5�      