   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5           HuongDuongVillage.MealCard   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:HuongDuongVillage  5      $��50��5	      .��5
      � .+�5   
   ��   �� CornerRadius$  10��6   
�������$��20 5 5 5q�6:   ._�5      �  � ColumnDefinitions 5      �� 5      $��80 �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $	��123 �6'   .+�5      �� 
�������$��0,0,1,0q�6,   ._�5      �� -   5         ��Name$ mealID��5   $   $��14(�64   $��1��6B   $��	10,0,10,0q�6K    �� TextAlignment$ Center=�6_   $��Center=�6v   
���   �6�   5      �� 5      $��1��6   
�������$��0,0,1,0q�6<   ._�5      �� -   5        $ mealRoomName��5   $   $��14(�6:   $��5��6H   $��	10,0,10,0q�6Q   $
��Left=�6d   $��Center=�6   
���   �6�   5      �� 5      $��2��6   
�������$��0,0,1,0q�6<   ._�5      �� -   5        $ mealName��5   $   $��14(�66   $��Pho ga��6D   $��	10,0,10,0q�6R   $
��Left=�6e   $��Center=�6�   5      �� 5      -   5         ��Name$ mealAddtionalNote��5      $��3��68   $��Center=�6H   $��Center=�6e   .+�5       �� -   5         ��Name$ 
mealStatus��5       $��80��5!       $��14(�5"      $
��Auto��5#      $
��Left=�5$       �� SelectedValuePath$ Content��5&      .@�5(      �� $��Not done��6'   �� 5)      $
��Done��6'   ��5*      �� 5+      .R�5,   "   $� 5-      5/      50      51      52      53      54      