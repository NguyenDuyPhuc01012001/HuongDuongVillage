   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5   	   )    #HuongDuongVillage.ManageServiceType   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HuongDuongVillage     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � WindowStyle$
  None=�5   	    � Title$ Manage Service��5
   	   $	��400��5   	   $	��750��6    � 
ResizeMode$ NoResize=�6"    � WindowStartupLocation$ CenterScreen=�68   .��5      �� 
������� �� CornerRadius$ 10��6    $��2q�62   ���	#FFF38413._�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��2* �6#   60   .+�5      � -   5         �Name$ restaurantInformation��5      $��Center=�62   .+�5      �� $��/GUI/village_logo.png��6   5      � 5      -   5        $ gridInfo��5      $��1��6%   $��0,50,0,0q�65    � RowDefinitions 5      �� 5      6&   �� 5      6&   �� 5      6&   �� 5      6&    5      �� 5      6)   �� 5      $��3* �6'   64   .+�5       �� -   5         ��Name$ 
lbNameMeal��5!      $
��Name��6)   $��Right=�5"      $��Center=�6-   
���   �$��18(�5#   +   $
��Bold"�5$      $��0��6-   � 5%      -   5        $ grdNameMeal��5&      $��50,0,0,0q�5'      $��1��5(      .+�5)      �� -   5        	 ��Name$	 recNameMeal��5)       $��40��5*      $	��300��63   
 �� RadiusX$
 5��5+       �� RadiusY$ 5��63   
�������$
��Left=�5,   1   �� 5-      -   5         ��Name$ 
txbSerName��5.      $��Center=�5/      $��Center=�50      $
��Left=�51      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Service name��53      $��14(�55      $
��Bold"�5:      $��10q�5;      $�� ��6"   ��52      �� *ActualWidth+ �� ElementName$ recNameMeal����54      �� *ActualHeight+$ recNameMeal����56      �� *BorderThickness+$ txbNameMeal�� �� MaxLines 57      �� *
MaxLines+$ txbNameMeal����58      �� *HorizontalContentAlignment+$ txbNameMeal��5;   "   5<      �� 5=      -   5        $ 
lbCategory��5>      $��Service type��5?      $��1��5@      ��5A      �� *HorizontalAlignment+$ 
lbNameMeal����5B      �� *VerticalAlignment+$ 
lbNameMeal����5C      �� *
Foreground+$ 
lbNameMeal����5D      �� *
FontSize+$ 
lbNameMeal����5E      �� *
FontWeight+$ 
lbNameMeal��� 5F      -   5        $ grdCategory��5G      $��1��5H      $��1��6)   ��5G   )   �� *Margin+$ grdNameMeal��.+�5I      �� -	   5        $	 recCategory��5I       ��5J      �� *ActualHeight+$ recNameMeal����5K      �� *ActualWidth+$ recNameMeal��
 5L      �� *	RadiusX+$ recNameMeal�� 5M      �� *	RadiusY+$ recNameMeal����5N      �� *Stroke+$ recNameMeal����5O      �� *Margin+$ recNameMeal����5P      �� *HorizontalAlignment+$ recNameMeal���� 5Q      -
   5        $��cmbCategory��5R      $��Center=�5S      $ Service type��5T      $
��Bold"�5U       �� 
IsEditable$ False��5V      $��Center=�5W      $
��Left=�5X      $��10q�5Y      $��14(�5Z       �� SelectedValuePath$ Content��5[      ��5\      �� *ActualHeight+$ recNameMeal����5]      �� *ActualWidth+$ recNameMeal����5^      �� *#!LongListToTestComboVirtualization+.@�5_      �� .��6'   food6-   �� 5`      .��6'   bar6,   �� 5a      .��6'   	cleaner60   ��5b      �� 5c      .R�5d   "   $� 5e      5g      5h      �� 5i      -   5        $ lbPriceMeal��5j      $��Price��6)   $��2��6=   ��5k      �� *HorizontalAlignment+$ 
lbNameMeal����5l      �� *VerticalAlignment+$ 
lbNameMeal����5m      �� *
Foreground+$ 
lbNameMeal����5n      �� *
FontSize+$ 
lbNameMeal����5o      �� *
FontWeight+$ 
lbNameMeal��� 5p      -   5        $ grdPriceMeal��5q      $��1��6)   $��2��6=   ��5r      �� *Margin+$ grdNameMeal��.+�5s      �� -   5        $	 recPriceMeal��5s       ��5t      �� *ActualHeight+$ recNameMeal����5u      �� *ActualWidth+$ recNameMeal��
 5v      �� *	RadiusX+$ recNameMeal�� 5w      �� *	RadiusY+$ recNameMeal����5x      �� *Stroke+$ recNameMeal����5y      �� *HorizontalAlignment+$ recNameMeal���� 5z      -   5        $ txbSerPrice��5{      $��Center=�5|      $��Center=�5}      $
��Left=�5~      $ Service price��5�      $��14(�5�      $
��Bold"�5�      $��10q�5�      $�� ��6"   ��5      �� *ActualWidth+$ recNameMeal����5�      �� *ActualHeight+$ recNameMeal����5�      �� *BorderThickness+$ txbNameMeal�� 5�      �� *
MaxLines+$ txbNameMeal����5�      �� *HorizontalContentAlignment+$ txbNameMeal��5�   "   5�      � 5�      -   5        $ grdSelection��5�      $��Center=�5�      $
��Left=�6.   $��6��5�      $��1��6    ��5�      �� *ActualWidth+$ recNameMeal����5�      �� *Margin+$ grdNameMeal�� 5�      �� 5�      6-   �� 5�      6-   �� 5�      6-   .+�5�      �� -   5         ��Name$ 
btnConfirm��5�      $��0��61   ���	#FFF38413$��Confirm��5�   0   
�������$��11(�5�   ,   $
��Bold"�6:    !  MaterialDesignFlatMidBgButton#��[  5�      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5�      6G   �� 5�      -   5        $ 	btnCancel��5�      $��2��60   $��Cancel��5�   S   $��11(�5�   S      MaterialDesignOutlinedButton#��[ 5�      $ 10��5�      ��5�      �� *
Foreground+$ 
btnConfirm����5�      �� *
Background+$ 
btnConfirm����5�      �� *
FontWeight+$ 
btnConfirm��5�   G   5�      5�      5�      5�      5�      