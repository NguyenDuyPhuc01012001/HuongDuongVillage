   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5   	        HuongDuongVillage.FormChef   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HuongDuongVillage     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � 
ResizeMode$  NoResize=�5	   	    � Title$ Chef's Form��5
   	   $	��733��6    � SizeToContent$ WidthAndHeight=�6-   $	��900��6L    � WindowStartupLocation$ CenterScreen=�6[    � WindowStyle$
 None=�6�    � 	Resources 5         NavigateBar �� Color  Top  Add  TextInNavigate  	TextOnTop��%�   &	        &	 !     &	 B     &	 c     &	 �     �� 5   
   $ #1a2a6c��6.   �� 5   
   $ #fdbb2d��6&   �� 5   
   $ #fdbb2d��6&   �� 5   
   $ White��61   �� 5   
   $ #403B4A��6,   5      .��5      �� 
���   �$��2q�6!   ._�5   
   � .+�5      �  � RowDefinitions 5      �� 5      $��60 �6$   �� 5      .+�5      � $��60��6   $��0��6#   $	��Top=�60   ���#fdbb2d J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 1Q�6+   
   ShadowDepth$
 1Q�6:      Color$ 	#FFACACAC��6J   .+�5      �� $
��Chef��6    $��50(�6,   $
��Bold"�6;   ���#403B4A K� Capitals$ AllSmallCaps=�6b   $��Center=�5      $��Center=�65   6S   �� 5       -   5         ��Name$ passwordSave��5!      $��Center=�5"      $��Center=�5#      $��35(�5$      
�������$y�Hidden=�5&      $	��asd��5'      �� 5(       �� Orientation$ 
Horizontal=�6!   $��Right=�6:   .+�5)      �� -   5        $ tblName��5)   $   $�� Chef��65   #���  6B   $��Center=�6k   $��18(�6�   6�   '  !MaterialDesignThemes.Wpf.PopupBox  5*      $��5q�5+      #���  5,         PlacementMode$ BottomAndAlignRightEdges=�5-         	StaysOpen$
 True��5.         PopupContent. 50      �� $	��160��6)   .+�51   "   �� -   5         ��Name$ 
InfoButton��52      $��5q�53      $��Center=�54      $��Center=�55       � Cursor$
 Hand��57      .��58   &   �� $��Center=�61   $ 
Horizontal=�6L   .+�59   *   '  !MaterialDesignThemes.Wpf.PackIcon  $
��auto��5:   %   $
��auto��5;   %   $	��5,0q�5<   %   $��Center=�5=   %   #���   5>   %      Kind$ 
InfoCircle=�5?   %   �� 5@   *   $
��auto��5A   %   $��Center=�5B   %   $��14(�5C   %   $��
Info Staff��5D   %   5E   '   5F   #   �� 5H   "   -   5        $��ChangepasswordButton��5I      $��5q�5J      $��Center=�5K      $��Center=�5L      $
 Hand��5N      .��5O   &   �� $ 
Horizontal=�61   .+�5P   *     $
��auto��5Q   %   $
��auto��5R   %   $	��5,0q�5S   %   $��Center=�5T   %   #���   5U   %   $ PasswordReset=�5V   %   �� 5W   *   $
��auto��5X   %   $��Center=�5Y   %   $��14(�5Z   %   $��Change password��5[   %   5\   '   5]   #   �� 5^   "   -   5        $ Reload��5_      $��5q�5`      $��Center=�5a      $��Center=�5b      $
 Hand��5d      .��5e   &   �� $��Center=�61   $ 
Horizontal=�6L   .+�5f   *     $
��auto��5g   %   $
��auto��5h   %   $	��5,0q�5i   %   $��Center=�5j   %   #���   5k   %   $ Reload=�5l   %   �� 5m   *   $
��auto��5n   %   $��Center=�5o   %   $��14(�5p   %   $��Reload page��5q   %   5r   '   5s   #   �� 5t   "   �� 5u   "   -   5        $ LogoutButton��5v      $��5q�5w      $��Center=�5x      $��Center=�5y      $
 Hand��5{      .��5|   &   �� $ 
Horizontal=�61   .+�5}   *     $
��auto��5~   %   $
��auto��5   %   $	��5,0q�5�   %   $��Center=�5�   %   #���   5�   %   $ Logout=�5�   %   �� 5�   *   $
��auto��5�   %   $��Center=�5�   %   $��14(�5�   %   $��Logout��5�   %   5�   '   5�   #   5�      5�      5�      5�      � 5�      $��1��6   $��0,10,0,0q�6$    5�      �� 5�      $��30 �6(   �� 5�      .+�5�      � $��0��6   .+�5�      #   HuongDuongVillage.MealManager  5�      � 5�      -   5         �Name$ mealCardContainer��5�      $��1��66   $��0,50,0,0q�6C   .+�5�      �� $��	0,-50,0,0q�6'   .��5�      �� -   5         ��Name$ 
ListHolder��5�   )   $ Vertical=�6=   5�      5�      5�      5�      5�      5�      5�      5�      