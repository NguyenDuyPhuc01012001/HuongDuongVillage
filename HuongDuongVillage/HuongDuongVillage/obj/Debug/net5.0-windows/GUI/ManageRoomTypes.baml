   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5   	   +    %HuongDuongVillage.GUI.ManageRoomTypes   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HuongDuongVillage     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � WindowStyle$
  None=�5   	    � Title$ Manage Roomtype��5
   	   $	��280��6!   $	��900��6.    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P   .��5      �� 
������� �� CornerRadius$ 10��6    $��2q�62   ���	#FFF38413._�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��2* �6#   60   .+�5      � -   5         �Name$ restaurantInformation��5      $��Center=�62   .+�5      �� $��/GUI/village_logo.png��6   5      � 5      -   5        $ gridInfo��5      $��1��6%   $��0,50,0,0q�65    � RowDefinitions 5      �� 5      6&   �� 5      6&   �� 5      6&    5      �� 5      6)   �� 5      $��3* �6'   64   .+�5      �� -   5         ��Name$ 
lbNameMeal��5      $
��Type��6)   $��Right=�5       $��Center=�6-   
���   �$��18(�5!   +   $
��Bold"�5"      $��0��6-   � 5#      -   5        $ grdNameMeal��5$      $��50,0,0,0q�5%      $��1��5&      .+�5'      �� -   5        	 ��Name$	 recNameMeal��5'       $��40��5(      $	��300��63   
 �� RadiusX$
 5��5)       �� RadiusY$ 5��63   
�������$
��Left=�5*   1   �� 5+      -   5         ��Name$ txbRoomType��5,      $��Center=�5-      $��Center=�5.      $
��Left=�5/      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Room type��51      $��14(�53      $
��Bold"�58      $��10q�59      $�� ��6"   ��50      �� *ActualWidth+ �� ElementName$ recNameMeal����52      �� *ActualHeight+$ recNameMeal����54      �� *BorderThickness+$ txbNameMeal�� �� MaxLines 55      �� *
MaxLines+$ txbNameMeal����56      �� *HorizontalContentAlignment+$ txbNameMeal��59   "   5:      �� 5<      -   5        $ lbPriceMeal��5=      $��Price��6)   $��1��6=   ��5>      �� *HorizontalAlignment+$ 
lbNameMeal����5?      �� *VerticalAlignment+$ 
lbNameMeal����5@      �� *
Foreground+$ 
lbNameMeal����5A      �� *
FontSize+$ 
lbNameMeal����5B      �� *
FontWeight+$ 
lbNameMeal��� 5C      -   5        $ grdPriceMeal��5D      $��1��6)   $��1��6=   ��5E      �� *Margin+$ grdNameMeal��.+�5F      �� -	   5        $	 recPriceMeal��5F       ��5G      �� *ActualHeight+$ recNameMeal����5H      �� *ActualWidth+$ recNameMeal��
 5I      �� *	RadiusX+$ recNameMeal�� 5J      �� *	RadiusY+$ recNameMeal����5K      �� *Stroke+$ recNameMeal����5L      �� *HorizontalAlignment+$ recNameMeal���� 5M      -
   5        $ txbRoomPrice��5N      $��Center=�5O      $��Center=�5P      $
��Left=�5Q      $ 
Room price��5S      $��14(�5U      $
��Bold"�5Z      $��10q�5[      $�� ��6"   ��5R      �� *ActualWidth+$ recNameMeal����5T      �� *ActualHeight+$ recNameMeal����5V      �� *BorderThickness+$ txbNameMeal�� 5W      �� *
MaxLines+$ txbNameMeal����5X      �� *HorizontalContentAlignment+$ txbNameMeal��5[   "   5\      � 5]      -   5        $ grdSelection��5]      $��Center=�5`      $
��Left=�6.   $��6��5a      $��1��6    ��5^      �� *ActualWidth+$ recNameMeal����5_      �� *Margin+$ grdNameMeal�� 5b      �� 5c      6-   �� 5d      6-   �� 5e      6-   .+�5g      �� -   5         ��Name$ 
btnConfirm��5g      $��0��61   ���	#FFF38413$��Confirm��5h   0   
�������$��11(�5i   ,   $
��Bold"�6:    !  MaterialDesignFlatMidBgButton#��[  5j      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5k      6G   �� 5m      -   5        $ 	btnCancel��5m      $��2��60   $��Cancel��5n   S   $��11(�5o   S      MaterialDesignOutlinedButton#��[ 5q      $ 10��5r      ��5n      �� *
Foreground+$ 
btnConfirm����5o      �� *
Background+$ 
btnConfirm����5p      �� *
FontWeight+$ 
btnConfirm��5r   G   5s      5t      5u      5v      5w      