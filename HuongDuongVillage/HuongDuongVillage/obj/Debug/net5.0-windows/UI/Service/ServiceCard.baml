   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5      #    HuongDuongVillage.ServiceCard   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HuongDuongVillage     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $��50��5	      .��5      � .+�5   
   �� $��20,5,5,5q�5      
�������  �� CornerRadius$  10��5      ._�5      �  � ColumnDefinitions 5      �� 5      �� 5      $	��100 �6'   �� 5      $	��100 �6'   �� 5      $	��120 �6'   �� 5      $	��100 �6'   �� 5      $	��145 �6'   .+�5      �� 
�������$��0,0,1,0q�6,   ._�5      �� -   5         ��Name$ tblName��5      $
��10,0q�5      $
��Left=�5      $��Center=�5      $��14(�5      
���   �$��Pho Bò��5!      $
��Wrap=�5"      5#      �� 5$      $��3��5%      
�������$��0,0,1,0q�5'      ._�5(      �� -   5        $ tblRoomName��5)      $
��10,0q�5*      $��Center=�5+      $��Center=�5,      $��14(�5-      
���   �$��15��5/      50      �� 51      $��2��52      
�������$��0,0,1,0q�54      ._�55      �� -   5        $ tblPrice��56      $
��10,0q�57      $��Center=�58      $��Center=�59      $��14(�5:      
���   �$��100000��5<      5=      �� 5>      $��1��5?      
�������$��0,0,1,0q�5A      ._�5B      �� -   5        $ tblType��5C      $
��10,0q�5D      $��Center=�5E      $��Center=�5F      $��14(�5G      
���   �$
��Food��5I      5J      �� 5K      $��4��5L      
�������$��0,0,1,0q�5N      ._�5O      �� -   5        $ 	tblStatus��5P      $
��10,0q�5Q      $��Center=�5R      $��Center=�5S      $��14(�5T      
���   �$
��Done��5V      5W      � 5X      $��5��6   $��Center=�6'    5Y      �� 5Z      �� 5[      �� 5\      .+�5^      �� -   5         ��Name$ 
editButton��5_      $��0��5`      $
��auto��5a      
�������
�������.��5f      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��editIcon��5g      
�������   Kind$ Pencil=�5i      5j      �� 5k      $��1��5l      $��41��5m      $��20��5n      
������� � LayoutTransform 5p      �� 5q       �� Angle$ 90Q�6.   5s      �� 5t      -   5        $ deleteButton��5u      $��2��5v      $
��auto��5w      
�������
�������.��5|        -	   5          Name$ 
deleteIcon��5}      
�������$ 
GarbageCan=�5      5�      5�      5�      5�      5�      5�      