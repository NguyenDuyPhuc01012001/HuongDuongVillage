   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5      '    !HuongDuongVillage.ServiceTypeCard   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HuongDuongVillage     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $��50��5	      .��5      � .+�5   
   �� $��20,5,5,5q�5      
�������  �� CornerRadius$  10��5      ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��3* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $
��1.5* �6'   .+�5      �� 
�������$��0,0,1,0q�6,   ._�5      �� -   5         ��Name$ categoryIDContainer��5      $��0��5      $��Center=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� -   5         ��Name$ tbkID��5       $��	10,0,10,0q�5!      $��Center=�5"      $��Center=�5#      
���   �$��1��5%      5&      5'      �� 5(      $��1��6   
�������$��0,0,1,0q�6<   ._�5)      �� -   5        $ categoryName��5*      $��Center=�5,      $ Vertical=�5-      .+�5.      �� -   5        $ tbkName��5/      $��	10,0,10,0q�50      $��Center=�51      
���   �$��Pho Bo`��53      $
��Wrap=�54      55      56      �� 57      $��2��6   
�������$��0,0,1,0q�6<   ._�58      �� $��2��6!   $ 
Horizontal=�61   .+�5:      �� -   5        $ tbkType��5;      $��	10,0,10,0q�5<      $��Center=�5=      $��Center=�5>      
���   �$
��Food��5@      5A      5B      �� 5C      $��3��6   
�������$��0,0,1,0q�6<   ._�5D      �� $��3��6!   $ 
Horizontal=�61   .+�5F      �� -   5        $ tbkPrice��5G      $��	10,0,10,0q�5H      $��Center=�5I      $��Center=�5J      
���   �$��100000��5L      5M      5N      �� 5P      $��4��6   
�������._�5Q      � $��Center=�6   $��5,0,0,0q�68   $��4��6I    5R      �� 5S      �� 5T      �� 5U      .+�5W      �� -   5         ��Name$ 
editButton��5X      $��0��5Y      
�������
�������.��5^      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��addIcon��5_      
�������   Kind$ Pencil=�5a      5b      �� 5c      $��1��5d      $��41��5e      $��20��5f      
������� � LayoutTransform 5h      �� 5i   "    �� Angle$ 90Q�62   5k      �� 5l      -	   5        $ deleteButton��5m      $��2��5n      
�������
�������.��5s        -
   5        	  Name$	 
deleteIcon��5t      
�������$ 
GarbageCan=�5v      5w      5x      5y      5z      5{      5|      5}      