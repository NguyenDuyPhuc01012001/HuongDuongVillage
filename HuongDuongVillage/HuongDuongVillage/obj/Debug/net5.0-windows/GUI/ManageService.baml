   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HuongDuongVillage.GUIHuongDuongVillage.GUI  5      %    HuongDuongVillage.ManageService   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:HuongDuongVillage.GUI     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      X TXceed.Wpf.Toolkit, Version=4.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5	        � Title$  ManageStaff��5
      $	��900��5      $	��500��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      �� 
����������	#FFF38413$��2q�5   	    �� CornerRadius$ 10��5   	   ._�5   
   �� $
��auto��5      $��40,20,40,10q�5       �� Orientation$ Vertical=�5      .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      $��50 �6'   �� 5       � RowDefinitions 5!      �� 5"      �� 5#      .+�5%      �� -   5         ��Name$ lblNameRoom��5&      $��0��5'      $
��Left=�5(      $��Center=�5)      $��	Room Name��5*      $��18(�5+      $
��Bold"�5,      
���   �5-      � 5.      -   5        	 �Name$	 grdNameRoom��5/      $��1��50      $��
30,10,0,20q�51      .+�52      �� -   5        
 ��Name$
 recNameRoom��53      $	��310��54      $��40��55      $
��Left=�56       �� RadiusX$ 5��57       �� RadiusY$ 5��58      
�������59      �� 5:      -   5         ��Name$ txbNameRoom��5;      $��5q�5>      $
��Left=�5?      $��Center=�5@      $
��Left=�5A      $��Center=�5B      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Room's Name��5C      $��0q�5D      $��14(�5E       �� 
IsReadOnly$
 True��5F      $
��Bold"�5G       �� MaxLines$ 1��5H      $y�Hidden=�5J      ��5<      �� *ActualWidth+ �� ElementName$ recNameRoom����5=      �� *ActualHeight+$ recNameRoom�� �� SelectionBrush 5I      Z� 5J      �� 5K      -   5         ��Name$ cmbNameRoom��5L      $��5q�5O      $ Room's Name��5T       �� DisplayMemberPath$ RoomName��5V       �� SelectedValuePath$ ID��5Y      ��5M      �� *ActualWidth+$ txbNameRoom����5N      �� *ActualHeight+$ txbNameRoom����5P      �� *HorizontalAlignment+$ txbNameRoom����5Q      �� *VerticalAlignment+$ txbNameRoom����5R      �� *HorizontalContentAlignment+$ txbNameRoom����5S      �� *VerticalContentAlignment+$ txbNameRoom����5U      �� *BorderThickness+$ txbNameRoom����5W      �� *
FontSize+$ txbNameRoom����5X      �� *
FontWeight+$ txbNameRoom��5Z      5[      �� 5\      -   5        $ 	lblStatus��5]      $��0��5^      $��2��5_      $��Service's status��5b      ��5`      �� *HorizontalAlignment+$ lblNameRoom����5a      �� *VerticalAlignment+$ lblNameRoom����5c      �� *
FontSize+$ lblNameRoom����5d      �� *
FontWeight+$ lblNameRoom����5e      �� *
Foreground+$ lblNameRoom��� 5f      -   5        $	 	grdStatus��5g      $��1��5h      $��2��5i      ��5j      �� *Margin+$ grdNameRoom��.+�5k      �� -   5        $
 	recStatus��5l      ��5m      �� *ActualWidth+$ recNameRoom����5n      �� *ActualHeight+$ recNameRoom����5o      �� *HorizontalAlignment+$ recNameRoom�� 5p      �� *	RadiusX+$ recNameRoom�� 5q      �� *	RadiusY+$ recNameRoom����5r      �� *Stroke+$ recNameRoom���� 5s      -	   5        $ 	txbStatus��5t      $��5q�5w      $ Status��5|      $
 True��5�      ��5u      �� *ActualWidth+$ txbNameRoom����5v      �� *ActualHeight+$ txbNameRoom����5x      �� *HorizontalAlignment+$ txbNameRoom����5y      �� *VerticalAlignment+$ txbNameRoom����5z      �� *HorizontalContentAlignment+$ txbNameRoom����5{      �� *VerticalContentAlignment+$ txbNameRoom����5}      �� *BorderThickness+$ txbNameRoom����5~      �� *
FontSize+$ txbNameRoom����5      �� *
FontWeight+$ txbNameRoom�� 5�      �� *
MaxLines+$ txbNameRoom��5�      5�      � 5�      -
   5        $��
grdCusInfo��5�       5�      �� 5�      �� 5�      $��50 �6'   �� 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ 	lblIDCard��5�      $��0��5�      $��Customer's ID card��5�      ��5�      �� *HorizontalAlignment+$ lblNameRoom����5�      �� *VerticalAlignment+$ lblNameRoom����5�      �� *
FontSize+$ lblNameRoom����5�      �� *
FontWeight+$ lblNameRoom����5�      �� *
Foreground+$ lblNameRoom��� 5�      -   5        $	 	grdIDCard��5�      $��1��5�      ��5�      �� *Margin+$ grdNameRoom��.+�5�      �� -   5        $
 	recIDCard��5�      ��5�      �� *ActualWidth+$ recNameRoom����5�      �� *ActualHeight+$ recNameRoom����5�      �� *HorizontalAlignment+$ recNameRoom�� 5�      �� *	RadiusX+$ recNameRoom�� 5�      �� *	RadiusY+$ recNameRoom����5�      �� *Stroke+$ recNameRoom���� 5�      -   5        $ 	txbIDCard��5�      $��5q�5�      $ Customer's IDCard number��5�      $
 True��5�      ��5�      �� *ActualWidth+$ txbNameRoom����5�      �� *ActualHeight+$ txbNameRoom����5�      �� *HorizontalAlignment+$ txbNameRoom����5�      �� *VerticalAlignment+$ txbNameRoom����5�      �� *HorizontalContentAlignment+$ txbNameRoom����5�      �� *VerticalContentAlignment+$ txbNameRoom����5�      �� *BorderThickness+$ txbNameRoom����5�      �� *
FontSize+$ txbNameRoom����5�      �� *
FontWeight+$ txbNameRoom�� 5�      �� *
MaxLines+$ txbNameRoom��5�      5�      �� 5�      -   5        $ 
lblNameCus��5�      $��0��5�      $��2��5�      $��Customer's name��5�      ��5�      �� *HorizontalAlignment+$ lblNameRoom����5�      �� *VerticalAlignment+$ lblNameRoom����5�      �� *
FontSize+$ lblNameRoom����5�      �� *
FontWeight+$ lblNameRoom����5�      �� *
Foreground+$ lblNameRoom��� 5�      -   5        $	 
grdNameCus��5�      $��1��5�      $��2��5�      ��5�      �� *Margin+$ grdNameRoom��.+�5�      �� -   5        $
 
recNameCus��5�      ��5�      �� *ActualWidth+$ recNameRoom����5�      �� *ActualHeight+$ recNameRoom����5�      �� *HorizontalAlignment+$ recNameRoom�� 5�      �� *	RadiusX+$ recNameRoom�� 5�      �� *	RadiusY+$ recNameRoom����5�      �� *Stroke+$ recNameRoom���� 5�      -   5        $ 
txbNameCus��5�      $��5q�5�      $ Customer's name��5�      $
 True��5�      ��5�      �� *ActualWidth+$ txbNameRoom����5�      �� *ActualHeight+$ txbNameRoom����5�      �� *HorizontalAlignment+$ txbNameRoom����5�      �� *VerticalAlignment+$ txbNameRoom����5�      �� *HorizontalContentAlignment+$ txbNameRoom����5�      �� *VerticalContentAlignment+$ txbNameRoom����5�      �� *BorderThickness+$ txbNameRoom����5�      �� *
FontSize+$ txbNameRoom����5�      �� *
FontWeight+$ txbNameRoom�� 5�      �� *
MaxLines+$ txbNameRoom��5�      5�      � 5�       5�      �� 5�      �� 5�      $��50 �6'   �� 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $ lblType��5�      $��0��5�      $��Service Type��5�      ��5�      �� *HorizontalAlignment+$ lblNameRoom����5�      �� *VerticalAlignment+$ lblNameRoom����5�      �� *
FontSize+$ lblNameRoom����5�      �� *
FontWeight+$ lblNameRoom����5�      �� *
Foreground+$ lblNameRoom��� 5�      -   5        $	 grdType��5�      $��1��5�      ��5�      �� *Margin+$ grdNameRoom��.+�5�      �� -   5        $
 recType��5�      ��5�      �� *ActualWidth+$ recNameRoom����5�      �� *ActualHeight+$ recNameRoom����5�      �� *HorizontalAlignment+$ recNameRoom�� 5�      �� *	RadiusX+$ recNameRoom�� 5�      �� *	RadiusY+$ recNameRoom����5�      �� *Stroke+$ recNameRoom���� 5�      -   5        $ cmbType��5�      $��5q�5�      $ Service's Type��5     ��5�      �� *ActualWidth+$ txbNameRoom����5�      �� *ActualHeight+$ txbNameRoom����5�      �� *HorizontalAlignment+$ txbNameRoom����5      �� *VerticalAlignment+$ txbNameRoom����5     �� *HorizontalContentAlignment+$ txbNameRoom����5     �� *VerticalContentAlignment+$ txbNameRoom����5     �� *BorderThickness+$ txbNameRoom����5     �� *
FontSize+$ txbNameRoom����5     �� *
FontWeight+$ txbNameRoom����5     �� 5	     .R�5
  "   $� 5     5     5     �� 5     -   5        $ 
lblSerName��5     $��0��5     $��2��5     $��Service Name��5     ��5     �� *HorizontalAlignment+$ lblNameRoom����5     �� *VerticalAlignment+$ lblNameRoom����5     �� *
FontSize+$ lblNameRoom����5     �� *
FontWeight+$ lblNameRoom����5     �� *
Foreground+$ lblNameRoom��� 5     -   5        $	 
grdSerName��5     $��1��5     $��2��5     ��5     �� *Margin+$ grdNameRoom��.+�5     �� -   5        $
 
recSerName��5     ��5      �� *ActualWidth+$ recNameRoom����5!     �� *ActualHeight+$ recNameRoom����5"     �� *HorizontalAlignment+$ recNameRoom�� 5#     �� *	RadiusX+$ recNameRoom�� 5$     �� *	RadiusY+$ recNameRoom����5%     �� *Stroke+$ recNameRoom���� 5&     -   5        $ 
cmbSerName��5'     $��5q�5*     $ Service's Name��5/     $ SerName��51     $ ID��54     ��5(     �� *ActualWidth+$ txbNameRoom����5)     �� *ActualHeight+$ txbNameRoom����5+     �� *HorizontalAlignment+$ txbNameRoom����5,     �� *VerticalAlignment+$ txbNameRoom����5-     �� *HorizontalContentAlignment+$ txbNameRoom����5.     �� *VerticalContentAlignment+$ txbNameRoom����50     �� *BorderThickness+$ txbNameRoom����52     �� *
FontSize+$ txbNameRoom����53     �� *
FontWeight+$ txbNameRoom����56     �� 57     .R�58  "   $� 59     5;     5<     5=     � 5>      5?     �� 5@     �� 5A     $��50 �6'   �� 5B      5D     �� 5E     �� 5F     .+�5H     �� -   5        $ lblQuantity��5I     $��0��5J     $��Quantity��5M     ��5K     �� *HorizontalAlignment+$ lblNameRoom����5L     �� *VerticalAlignment+$ lblNameRoom����5N     �� *
FontSize+$ lblNameRoom����5O     �� *
FontWeight+$ lblNameRoom����5P     �� *
Foreground+$ lblNameRoom��� 5Q     -   5        $	 grdQuantity��5R     $��1��5S     ��5T     �� *Margin+$ grdNameRoom��.+�5U     �� -   5        $
 recQuantity��5V     $��Stretch=�5Z      K� ZIndex$ 10��5[     ��5W     �� *ActualWidth+$ recNameRoom����5X     �� *ActualHeight+$ recNameRoom����5Y     �� *HorizontalAlignment+$ recNameRoom�� 5\     �� *	RadiusX+$ recNameRoom�� 5]     �� *	RadiusY+$ recNameRoom����5^     �� *Stroke+$ recNameRoom��%  Xceed.Wpf.Toolkit.IntegerUpDown  5_     -   5          Name$ iudQuantity��5`     $��5q�5c     �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   FormatString$ N0��5k        	Increment 15l     �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   Maximum 1005m        Minimum 15n     ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   TextAlignment$
 Left=�5o        Value 15q     ��5a     �� *ActualWidth+$ txbNameRoom����5b     �� *ActualHeight+$ txbNameRoom����5d     �� *HorizontalAlignment+$ txbNameRoom����5e     �� *VerticalAlignment+$ txbNameRoom����5f     �� *HorizontalContentAlignment+$ txbNameRoom����5g     �� *VerticalContentAlignment+$ txbNameRoom����5h     �� *BorderThickness+$ txbNameRoom����5i     �� *
FontSize+$ txbNameRoom����5j     �� *
FontWeight+$ txbNameRoom��5q     5r     �� 5s     -   5        $ lblPrice��5t     $��0��5u     $��2��5v     $��Price��5y     ��5w     �� *HorizontalAlignment+$ lblNameRoom����5x     �� *VerticalAlignment+$ lblNameRoom����5z     �� *
FontSize+$ lblNameRoom����5{     �� *
FontWeight+$ lblNameRoom����5|     �� *
Foreground+$ lblNameRoom��� 5}     -    5        $	 grdPrice��5~     $��1��5     $��2��5�     ��5�     �� *Margin+$ grdNameRoom��.+�5�     �� -!   5        $
 recPrice��5�     ��5�     �� *ActualWidth+$ recNameRoom����5�     �� *ActualHeight+$ recNameRoom����5�     �� *HorizontalAlignment+$ recNameRoom�� 5�     �� *	RadiusX+$ recNameRoom�� 5�     �� *	RadiusY+$ recNameRoom����5�     �� *Stroke+$ recNameRoom���� 5�     -"   5        $ txbPrice��5�     $��5q�5�     $ Room's Price��5�     $
 True��5�     ��5�     �� *ActualWidth+$ txbNameRoom����5�     �� *ActualHeight+$ txbNameRoom����5�     �� *HorizontalAlignment+$ txbNameRoom����5�     �� *VerticalAlignment+$ txbNameRoom����5�     �� *HorizontalContentAlignment+$ txbNameRoom����5�     �� *VerticalContentAlignment+$ txbNameRoom����5�     �� *BorderThickness+$ txbNameRoom����5�     �� *
FontSize+$ txbNameRoom����5�     �� *
FontWeight+$ txbNameRoom�� 5�     �� *
MaxLines+$ txbNameRoom��5�     5�     � 5�      5�     �� 5�     �� 5�     $��50 �6'   �� 5�      5�     �� 5�     �� 5�     .+�5�     � -#   5        $	 grdSelection��5�     $��10��5�     $��2��5�     $
��Left=�5�     $��Center=�5�     ��5�     �� *ActualWidth+$ recNameRoom����5�     �� *Margin+$ grdNameRoom�� 5�     �� 5�     �� 5�     �� 5�     .+�5�     �� -$   5         ��Name$ 
btnConfirm��5�     $��0��5�     +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5�     ���	#FFF38413$��Confirm��5�     $��11(�5�     $
��Bold"�5�     
������� !  MaterialDesignFlatMidBgButton#��[  5�     �� 5�     -%   5        $ 	btnCancel��5�     $��2��5�     $ 10��5�     $��Cancel��5�     $��11(�5�        MaterialDesignOutlinedButton#��[ 5�     ��5�     �� *
Foreground+$ 
btnConfirm����5�     �� *
FontWeight+$ 
btnConfirm����5�     �� *
Background+$ 
btnConfirm��5�     5�     5�     5�     5�     5�     