   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5      #    HuongDuongVillage.AccountCard   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HuongDuongVillage     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $��50��5	      .��5      �� $��20,5,5,5q�5   	   
�������  �� CornerRadius$  10��5   	   ._�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $	��200 �6#   �� 5      $	��150 �6#   .+�5      �� 
�������$��0,0,1,0q�6(   ._�5      �� -   5         ��Name$ ownerContainer��5       �� Orientation$ 
Horizontal=�65   .+�5      �� -   5         ��Name$ tblName��5      $
��10,0q�5      $��Center=�5      $��Center=�5      $��14(�5      
���   �$
��Phuc��5      5       5!      �� 5"      $��1��5#      
�������$��0,0,1,0q�5%      ._�5&      �� -   5        $ messageContainer��5'      $��Center=�5(      $ Vertical=�5)      .+�5+      �� -   5        $ tblUserName��5,      $
��10,0q�5-      $
��Left=�5.      $��Center=�5/      $��14(�50      
���   �$��Need clean room��52      $
��Wrap=�53      54      55      �� 56      $��2��57      
�������$��0,0,1,0q�59      ._�5:      �� $��Center=�6   $ Vertical=�68   .+�5<      �� -   5        $ tblWorkingRole��5=      $
��10,0q�5>      $
��Left=�5?      $��Center=�5@      $��14(�5A      
���   �$��Room problem��5C      $
��Wrap=�5D      5E      5F      � 5G      $��3��6   $��Center=�6#    5H      �� 5I      �� 5J      �� 5K      .+�5M      �� -   5         ��Name$ resetPasswordButton��5N      $��0��5O      $
��auto��5P      
�������
�������.��5V      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��resetPasswordIcon��5W      
�������   Kind$ PasswordReset=�5Y      5Z      �� 5[      $��1��5\      $��20��5]      
������� � LayoutTransform 5_      �� 5`       �� Angle$ 90Q�6*   5b      �� 5c      -   5        $ deleteButton��5d      $��2��5e      $
��auto��5f      
�������
�������.��5l        -	   5        	  Name$	 
deleteIcon��5m      
�������$ 
GarbageCan=�5o      5p      5q      5r      5s      5t      