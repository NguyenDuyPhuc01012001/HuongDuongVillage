   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5      $    HuongDuongVillage.RoomTypeCard   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HuongDuongVillage     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $��50��5	      .��5      � .+�5   
   �� $��20,5,5,5q�5      
�������  �� CornerRadius$  10��5      ._�5      �  � ColumnDefinitions 5      �� 5      $	��110 �6'   �� 5      $��2* �6'   �� 5      $��2* �6'   �� 5      $��* �6'   �� 5      $	��145 �6'   .+�5      �� 
�������$��0,0,1,0q�6,   ._�5      �� -   5         ��Name$ roomName��5      $��0��5      $��Center=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� -   5         ��Name$ 	tblRoomID��5       $��Center=�5!      $��Center=�5"      
���   �$��1��5$      5%      5&      �� 5(      $��1��6   
�������$��0,0,1,0q�6<   ._�5)      �� $��1��5*      $��5,0,0,0q�5+      $��Center=�5,      $��Center=�5-      $ Vertical=�5.      .+�50      �� -   5        $ tblRoomType��51      $
��Left=�52      $��Center=�53      
���   �$��3B��55      $
��Wrap=�56      57      58      �� 5:      $��2��6   
�������$��0,0,1,0q�6<   ._�5;      �� -   5        $ 	roomPrice��5<      $��5,0,0,0q�5=      $��Center=�5>      $��2��5?      $ 
Horizontal=�5@      .+�5B      �� -   5        $ tblRoomPrice��5C      $��Center=�5D      $��Center=�5E      
���   �$
��100$��5G      5H      5I      �� 5J      $��3��6   
�������$��0,0,1,0q�6<   ._�5K      �� -   5        $ 	roomCount��5L      $��Center=�5M      $��5,0,5,0q�5N      $��2��5O      $ 
Horizontal=�5P      .+�5R      �� -   5        $ tblRoomCount��5S      $��Center=�5T      $��Center=�5U      
���   �$��15��5W      5X      5Y      �� 5Z      $��4��6   
�������._�5[      � $��5,0,0,0q�6   $��3��6,   $��Center=�6<    5\      �� 5]      �� 5^      �� 5_      .+�5a      �� -   5         ��Name$ 
editButton��5b      $��0��5c      
�������
�������.��5i      '  !MaterialDesignThemes.Wpf.PackIcon  -	   5        $��addIcon��5j      
�������   Kind$ Pencil=�5l      5m      �� 5n      $��1��5o      $��41��5p      $��20��5q      
������� � LayoutTransform 5s      �� 5t   "    �� Angle$ 90Q�62   5v      �� 5w      -
   5        $ deleteButton��5x      $��2��5y      
�������
�������.��5        -   5        	  Name$	 
deleteIcon��5�      
�������$ 
GarbageCan=�5�      5�      5�      5�      5�      5�      5�      5�      