   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HuongDuongVillage.GUIHuongDuongVillage.GUI  5      "    HuongDuongVillage.ManageRoom   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:HuongDuongVillage.GUI     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  Manage Room��5	      $	��700��5
       � 
ResizeMode$ NoResize=�5       � SizeToContent$ WidthAndHeight=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      �� 
����������	#FFF38413$��2q�5   	    �� CornerRadius$ 10��5   	   ._�5   
   �� $
��auto��5      $��40,20,40,10q�5       �� Orientation$ Vertical=�5      .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      $��50 �6'   �� 5       � RowDefinitions 5       �� 5!      �� 5"      .+�5$      �� -   5        	 ��Name$	 lblNameRoom��5%      $��0��5&      $
��Left=�5'      $��Center=�5(      $
��Name��5)      $��18(�5*      $
��Bold"�5+      
���   �5,      � 5-      -   5        
 �Name$
 grdNameRoom��5.      $��1��5/      $��
30,10,0,20q�50      .+�51      �� -   5         ��Name$ recNameRoom��52      $	��310��53      $��40��54      $
��Left=�55       �� RadiusX$ 5��56       �� RadiusY$ 5��57      
�������58      �� 59      -   5         ��Name$ txbNameRoom��5:      $��5q�5;      $
��Left=�5>      $��Center=�5?      $
��Left=�5@      $��Center=�5A      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Room's Name��5B      $��0q�5C      $��14(�5D      $
��Bold"�5E       �� MaxLines$ 1��5F      ��5<      �� *ActualWidth+ �� ElementName$ recNameRoom����5=      �� *ActualHeight+$ recNameRoom�� �� SelectionBrush 5G      Z� �� 5H      -   5         ��Name$ cmbNameRoom��5I      $��5q�5J      $ Room's Name��5Q       �� DisplayMemberPath$ RoomName��5S       �� SelectedValuePath$ ID��5V      ��5K      �� *ActualWidth+$ txbNameRoom����5L      �� *ActualHeight+$ txbNameRoom����5M      �� *HorizontalAlignment+$ txbNameRoom����5N      �� *VerticalAlignment+$ txbNameRoom����5O      �� *HorizontalContentAlignment+$ txbNameRoom����5P      �� *VerticalContentAlignment+$ txbNameRoom����5R      �� *BorderThickness+$ txbNameRoom����5T      �� *
FontSize+$ txbNameRoom����5U      �� *
FontWeight+$ txbNameRoom��5W      5X      �� 5Y      -   5        $	 	lblStatus��5Z      $��0��5[      $��2��5\      $��Status��5_      ��5]      �� *HorizontalAlignment+$ lblNameRoom����5^      �� *VerticalAlignment+$ lblNameRoom����5`      �� *
FontSize+$ lblNameRoom����5a      �� *
FontWeight+$ lblNameRoom����5b      �� *
Foreground+$ lblNameRoom��� 5c      -   5        $
 	grdStatus��5d      $��1��5e      $��2��5f      ��5g      �� *Margin+$ grdNameRoom��.+�5h      �� -   5        $ 	recStatus��5i      ��5j      �� *ActualWidth+$ recNameRoom����5k      �� *ActualHeight+$ recNameRoom����5l      �� *HorizontalAlignment+$ recNameRoom�� 5m      �� *	RadiusX+$ recNameRoom�� 5n      �� *	RadiusY+$ recNameRoom����5o      �� *Stroke+$ recNameRoom���� 5p      -	   5        $ 	txbStatus��5q      $��5q�5r      $ Room's Status��5y       �� 
IsReadOnly$
 True��5}      ��5s      �� *ActualWidth+$ txbNameRoom����5t      �� *ActualHeight+$ txbNameRoom����5u      �� *HorizontalAlignment+$ txbNameRoom����5v      �� *VerticalAlignment+$ txbNameRoom����5w      �� *HorizontalContentAlignment+$ txbNameRoom����5x      �� *VerticalContentAlignment+$ txbNameRoom����5z      �� *BorderThickness+$ txbNameRoom����5{      �� *
FontSize+$ txbNameRoom����5|      �� *
FontWeight+$ txbNameRoom�� 5~      �� *
MaxLines+$ txbNameRoom��5      5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� -
   5        $	 
lblAddress��5�      $��0��5�      $��Room address��5�      ��5�      �� *HorizontalAlignment+$ lblNameRoom����5�      �� *VerticalAlignment+$ lblNameRoom����5�      �� *
FontSize+$ lblNameRoom����5�      �� *
FontWeight+$ lblNameRoom����5�      �� *
Foreground+$ lblNameRoom��� 5�      -   5        $
 
grdAddress��5�      $��1��5�      $	��700��5�      ��5�      �� *Margin+$ grdNameRoom����5�      �� *HorizontalAlignment+$ recNameRoom��.+�5�      �� -   5        $ 
recAddress��5�      ��5�      �� *ActualWidth+$ 
grdAddress����5�      �� *ActualHeight+$ recNameRoom����5�      �� *Margin+$ recNameRoom����5�      �� *HorizontalAlignment+$ recNameRoom�� 5�      �� *	RadiusX+$ recNameRoom�� 5�      �� *	RadiusY+$ recNameRoom����5�      �� *Stroke+$ recNameRoom���� 5�      -   5        $ 
txbAddress��5�      $��5q�5�      $ Room's Address��5�       �� TextWrapping$
 Wrap=�5�      ��5�      �� *ActualWidth+$ 
grdAddress����5�      �� *ActualHeight+$ txbNameRoom����5�      �� *HorizontalAlignment+$ txbNameRoom����5�      �� *VerticalAlignment+$ txbNameRoom����5�      �� *HorizontalContentAlignment+$ txbNameRoom����5�      �� *VerticalContentAlignment+$ txbNameRoom����5�      �� *BorderThickness+$ txbNameRoom����5�      �� *
FontSize+$ txbNameRoom����5�      �� *
FontWeight+$ txbNameRoom�� 5�      �� *
MaxLines+$ txbNameRoom��5�      5�      5�      � 5�      -   5        $��
grdCusInfo��5�       5�      �� 5�      �� 5�      $��50 �6'   �� 5�       5�      �� 5�      �� 5�      .+�5�      �� -   5        $	 	lblIDCard��5�      $��0��5�      $��Customer's ID card��5�      ��5�      �� *HorizontalAlignment+$ lblNameRoom����5�      �� *VerticalAlignment+$ lblNameRoom����5�      �� *
FontSize+$ lblNameRoom����5�      �� *
FontWeight+$ lblNameRoom����5�      �� *
Foreground+$ lblNameRoom��� 5�      -   5        $
 	grdIDCard��5�      $��1��5�      ��5�      �� *Margin+$ grdNameRoom��.+�5�      �� -   5        $ 	recIDCard��5�      ��5�      �� *ActualWidth+$ recNameRoom����5�      �� *ActualHeight+$ recNameRoom����5�      �� *HorizontalAlignment+$ recNameRoom�� 5�      �� *	RadiusX+$ recNameRoom�� 5�      �� *	RadiusY+$ recNameRoom����5�      �� *Stroke+$ recNameRoom���� 5�      -   5        $ 	txbIDCard��5�      $��5q�5�      $ Customer's IDCard number��5�      ��5�      �� *ActualWidth+$ txbNameRoom����5�      �� *ActualHeight+$ txbNameRoom����5�      �� *HorizontalAlignment+$ txbNameRoom����5�      �� *VerticalAlignment+$ txbNameRoom����5�      �� *HorizontalContentAlignment+$ txbNameRoom����5�      �� *VerticalContentAlignment+$ txbNameRoom����5�      �� *BorderThickness+$ txbNameRoom����5�      �� *
FontSize+$ txbNameRoom����5�      �� *
FontWeight+$ txbNameRoom�� 5�      �� *
MaxLines+$ txbNameRoom��5�      5�      �� 5�      -   5        $	 
lblNameCus��5�      $��0��5�      $��2��5�      $��Customer's name��5�      ��5�      �� *HorizontalAlignment+$ lblNameRoom����5�      �� *VerticalAlignment+$ lblNameRoom����5�      �� *
FontSize+$ lblNameRoom����5�      �� *
FontWeight+$ lblNameRoom����5�      �� *
Foreground+$ lblNameRoom��� 5�      -   5        $
 
grdNameCus��5�      $��1��5�      $��2��5�      ��5�      �� *Margin+$ grdNameRoom��.+�5�      �� -   5        $ 
recNameCus��5�      ��5�      �� *ActualWidth+$ recNameRoom����5�      �� *ActualHeight+$ recNameRoom����5�      �� *HorizontalAlignment+$ recNameRoom�� 5�      �� *	RadiusX+$ recNameRoom�� 5�      �� *	RadiusY+$ recNameRoom����5�      �� *Stroke+$ recNameRoom���� 5�      -   5        $ 
txbNameCus��5�      $��5q�5�      $ Customer's name��5�      $
 True��5     ��5�      �� *ActualWidth+$ txbNameRoom����5�      �� *ActualHeight+$ txbNameRoom����5�      �� *HorizontalAlignment+$ txbNameRoom����5�      �� *VerticalAlignment+$ txbNameRoom����5�      �� *HorizontalContentAlignment+$ txbNameRoom����5�      �� *VerticalContentAlignment+$ txbNameRoom����5      �� *BorderThickness+$ txbNameRoom����5     �� *
FontSize+$ txbNameRoom����5     �� *
FontWeight+$ txbNameRoom�� 5     �� *
MaxLines+$ txbNameRoom��5     5     � 5      5     �� 5	     �� 5
     $��50 �6'   �� 5      5     �� 5     �� 5     .+�5     �� -   5        $	 lblType��5     $��0��5     $
��Type��5     ��5     �� *HorizontalAlignment+$ lblNameRoom����5     �� *VerticalAlignment+$ lblNameRoom����5     �� *
FontSize+$ lblNameRoom����5     �� *
FontWeight+$ lblNameRoom����5     �� *
Foreground+$ lblNameRoom��� 5     -   5        $
 grdType��5     $��1��5     ��5     �� *Margin+$ grdNameRoom��.+�5     �� -   5        $ recType��5     ��5      �� *ActualWidth+$ recNameRoom����5!     �� *ActualHeight+$ recNameRoom����5"     �� *HorizontalAlignment+$ recNameRoom�� 5#     �� *	RadiusX+$ recNameRoom�� 5$     �� *	RadiusY+$ recNameRoom����5%     �� *Stroke+$ recNameRoom���� 5&     -   5        $ txbType��5'     $y�Hidden=�5(     $��5q�5)     $ Room's Type��50     ��5*     �� *ActualWidth+$ txbNameRoom����5+     �� *ActualHeight+$ txbNameRoom����5,     �� *HorizontalAlignment+$ txbNameRoom����5-     �� *VerticalAlignment+$ txbNameRoom����5.     �� *HorizontalContentAlignment+$ txbNameRoom����5/     �� *VerticalContentAlignment+$ txbNameRoom����51     �� *BorderThickness+$ txbNameRoom����52     �� *
FontSize+$ txbNameRoom����53     �� *
FontWeight+$ txbNameRoom��.��6T   54     �� 55     -   5        $ cmbType��56     $��5q�57     $ Room's Type��5>     $ RoomType��5@     $ ID��5C     ��58     �� *ActualWidth+$ txbNameRoom����59     �� *ActualHeight+$ txbNameRoom����5:     �� *HorizontalAlignment+$ txbNameRoom����5;     �� *VerticalAlignment+$ txbNameRoom����5<     �� *HorizontalContentAlignment+$ txbNameRoom����5=     �� *VerticalContentAlignment+$ txbNameRoom����5?     �� *BorderThickness+$ txbNameRoom����5A     �� *
FontSize+$ txbNameRoom����5B     �� *
FontWeight+$ txbNameRoom����5E     �� 5F     .R�5G  "   $� 5H     5J     5K     �� 5L     -   5        $	 lblPrice��5M     $��0��5N     $��2��5O     $��Price��5R     ��5P     �� *HorizontalAlignment+$ lblNameRoom����5Q     �� *VerticalAlignment+$ lblNameRoom����5S     �� *
FontSize+$ lblNameRoom����5T     �� *
FontWeight+$ lblNameRoom����5U     �� *
Foreground+$ lblNameRoom��� 5V     -   5        $
 grdPrice��5W     $��1��5X     $��2��5Y     ��5Z     �� *Margin+$ grdNameRoom��.+�5[     �� -   5        $ recPrice��5\     ��5]     �� *ActualWidth+$ recNameRoom����5^     �� *ActualHeight+$ recNameRoom����5_     �� *HorizontalAlignment+$ recNameRoom�� 5`     �� *	RadiusX+$ recNameRoom�� 5a     �� *	RadiusY+$ recNameRoom����5b     �� *Stroke+$ recNameRoom���� 5c     -   5        $ txbPrice��5d     $��5q�5e     $ Room's Price��5l     $
 True��5p     ��5f     �� *ActualWidth+$ txbNameRoom����5g     �� *ActualHeight+$ txbNameRoom����5h     �� *HorizontalAlignment+$ txbNameRoom����5i     �� *VerticalAlignment+$ txbNameRoom����5j     �� *HorizontalContentAlignment+$ txbNameRoom����5k     �� *VerticalContentAlignment+$ txbNameRoom����5m     �� *BorderThickness+$ txbNameRoom����5n     �� *
FontSize+$ txbNameRoom����5o     �� *
FontWeight+$ txbNameRoom�� 5q     �� *
MaxLines+$ txbNameRoom��5r     5s     � 5t      5u     �� 5v     �� 5w     $��50 �6'   �� 5x      5z     �� 5{     �� 5|     .+�5~     �� -    5        $	 lblDateCheckIn��5     $��0��5�     $��DateCheckIn��5�     ��5�     �� *HorizontalAlignment+$ lblNameRoom����5�     �� *VerticalAlignment+$ lblNameRoom����5�     �� *
FontSize+$ lblNameRoom����5�     �� *
FontWeight+$ lblNameRoom����5�     �� *
Foreground+$ lblNameRoom��� 5�     -!   5        $
 grdDateCheckIn��5�     $��1��5�     ��5�     �� *Margin+$ grdNameRoom��.+�5�     �� -"   5        $ recDateCheckIn��5�     ��5�     �� *ActualWidth+$ recNameRoom����5�     �� *ActualHeight+$ recNameRoom����5�     �� *HorizontalAlignment+$ recNameRoom�� 5�     �� *	RadiusX+$ recNameRoom�� 5�     �� *	RadiusY+$ recNameRoom����5�     �� *Stroke+$ recNameRoom��(  "System.Windows.Controls.DatePicker  5�     -#   5          Name$ dpkDateCheckIn��5�     $��5q�5�     $ Date Check In��5�     ��5�     �� *ActualWidth+$ txbNameRoom����5�     �� *ActualHeight+$ txbNameRoom����5�     �� *HorizontalAlignment+$ txbNameRoom����5�     �� *VerticalAlignment+$ txbNameRoom����5�     �� *HorizontalContentAlignment+$ txbNameRoom����5�     �� *VerticalContentAlignment+$ txbNameRoom����5�     �� *BorderThickness+$ txbNameRoom����5�     �� *
FontSize+$ txbNameRoom����5�     �� *
FontWeight+$ txbNameRoom��5�     �� 5�     -$   5        $	 lblDateCheckOut��5�     $��0��5�     $��2��5�     $��DateCheckOut��5�     ��5�     �� *HorizontalAlignment+$ lblNameRoom����5�     �� *VerticalAlignment+$ lblNameRoom����5�     �� *
FontSize+$ lblNameRoom����5�     �� *
FontWeight+$ lblNameRoom����5�     �� *
Foreground+$ lblNameRoom��� 5�     -%   5        $
 grdDateCheckOut��5�     $��1��5�     $��2��5�     ��5�     �� *Margin+$ grdNameRoom��.+�5�     �� -&   5        $ recDateCheckOut��5�     ��5�     �� *ActualWidth+$ recNameRoom����5�     �� *ActualHeight+$ recNameRoom����5�     �� *HorizontalAlignment+$ recNameRoom�� 5�     �� *	RadiusX+$ recNameRoom�� 5�     �� *	RadiusY+$ recNameRoom����5�     �� *Stroke+$ recNameRoom��  5�     -'   5        $ dpkDateCheckOut��5�     $��5q�5�     $ DateCheckOut��5�     ��5�     �� *ActualWidth+$ txbNameRoom����5�     �� *ActualHeight+$ txbNameRoom����5�     �� *HorizontalAlignment+$ txbNameRoom����5�     �� *VerticalAlignment+$ txbNameRoom����5�     �� *HorizontalContentAlignment+$ txbNameRoom����5�     �� *VerticalContentAlignment+$ txbNameRoom����5�     �� *BorderThickness+$ txbNameRoom����5�     �� *
FontSize+$ txbNameRoom����5�     �� *
FontWeight+$ txbNameRoom��5�     5�     � 5�      5�     �� 5�     �� 5�     $��50 �6'   �� 5�      5�     �� 5�     �� 5�     .+�5�     � -(   5        $
 grdSelection��5�     $��10��5�     $��2��5�     $
��Left=�5�     $��Center=�5�     ��5�     �� *ActualWidth+$ recNameRoom����5�     �� *Margin+$ grdNameRoom�� 5�     �� 5�     �� 5�     �� 5�     .+�5�     �� -)   5         ��Name$ 
btnConfirm��5�     $��0��5�     +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5�     ���	#FFF38413$��Confirm��5�     $��11(�5�     $
��Bold"�5�     
������� !  MaterialDesignFlatMidBgButton#��[  5�     �� 5�     -*   5        $ 	btnCancel��5�     $��2��5�     $ 10��5�     $��Cancel��5�     $��11(�5�        MaterialDesignOutlinedButton#��[ 5�     ��5�     �� *
Foreground+$ 
btnConfirm����5�     �� *
FontWeight+$ 
btnConfirm����5�     �� *
Background+$ 
btnConfirm��5�     5�     5�     5�     5�     5�     