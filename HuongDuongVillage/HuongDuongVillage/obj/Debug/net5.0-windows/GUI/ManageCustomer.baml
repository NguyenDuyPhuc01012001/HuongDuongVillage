   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HuongDuongVillage.GUIHuongDuongVillage.GUI  5      &     HuongDuongVillage.ManageCustomer   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:HuongDuongVillage.GUI     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  Manage Customer��5	      $	��900��5
      $	��600��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      �� 
����������	#FFF38413$��2q�5   	    �� CornerRadius$ 10��5   	   ._�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      $��2* �6#   .+�5      � -   5         �Name$ vilageInformation��5      $��Center=�6.   .+�5      �� $��/GUI/village_logo.png��6   5      � 5      -   5        $ gridInfo��5      $��2��5       $��0,50,0,0q�5!       � RowDefinitions 5"      �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(       5*      �� 5+      �� 5,      $��20 �6'   �� 5-      $��3* �6'   .+�5/      �� $��0��50      $��1��51      $��Center=�52      $��*��53      $��18(�54      $
��Bold"�55      
���  ��56      �� 57      $��1��58      $��1��59      $��Center=�5:      $��*��5;      $��18(�5<      $
��Bold"�5=      
���  ��5>      �� 5?      $��2��5@      $��1��5A      $��Center=�5B      $��*��5C      $��18(�5D      $
��Bold"�5E      
���  ��5F      �� 5G      -   5         ��Name$ lblNameCustomer��5H      $��0��5I      $��Right=�5J      $��Center=�5K      $
��Name��5L      $��18(�5M      $
��Bold"�5N      
���   �5O      � 5P      -   5        $ grdNameCustomer��5Q      $��2��5R      $��30,0,0,0q�5S      .+�5T      �� -   5        	 ��Name$	 recNameCustomer��5U      $	��300��5V      $��40��5W      $
��Left=�5X      
 �� RadiusX$
 5��5Y       �� RadiusY$ 5��5Z      
�������5[      �� 5\      -   5         ��Name$ txbNameCustomer��5]      $��10q�5`      $
��Left=�5a      $��Center=�5b      $
��Left=�5c      $��Center=�5d      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Customer's Name��5e      $��0q�5f      $��14(�5g      $
��Bold"�5h       �� MaxLines$ 1��5i      ��5^      �� *ActualWidth+ �� ElementName$ recNameCustomer����5_      �� *ActualHeight+$ recNameCustomer�� �� SelectionBrush 5j      Z� 5k      �� 5l      -   5        $ 	lblIDCard��5m      $��1��5n      $��ID card��5q      ��5o      �� *HorizontalAlignment+$ lblNameCustomer����5p      �� *VerticalAlignment+$ lblNameCustomer����5r      �� *
FontSize+$ lblNameCustomer����5s      �� *
FontWeight+$ lblNameCustomer����5t      �� *
Foreground+$ lblNameCustomer��� 5u      -   5        $ 	grdIDCard��5v      $��1��5w      $��2��5x      ��5y      �� *ActualWidth+$ recNameCustomer����5z      �� *Margin+$ grdNameCustomer����5{      �� *HorizontalAlignment+$ recNameCustomer��.+�5|      �� -	   5        $	 	recIDCard��5}      ��5~      �� *ActualWidth+$ recNameCustomer����5      �� *ActualHeight+$ recNameCustomer����5�      �� *Margin+$ recNameCustomer����5�      �� *HorizontalAlignment+$ recNameCustomer��
 5�      �� *	RadiusX+$ recNameCustomer�� 5�      �� *	RadiusY+$ recNameCustomer����5�      �� *Stroke+$ recNameCustomer���� 5�      -
   5        $ 	txbIDCard��5�      $��10q�5�      $ Customer's ID card��5�      ��5�      �� *ActualWidth+$ txbNameCustomer����5�      �� *ActualHeight+$ txbNameCustomer����5�      �� *HorizontalAlignment+$ txbNameCustomer����5�      �� *VerticalAlignment+$ txbNameCustomer����5�      �� *HorizontalContentAlignment+$ txbNameCustomer����5�      �� *VerticalContentAlignment+$ txbNameCustomer����5�      �� *BorderThickness+$ txbNameCustomer����5�      �� *
FontSize+$ txbNameCustomer����5�      �� *
FontWeight+$ txbNameCustomer�� 5�      �� *
MaxLines+$ txbNameCustomer��5�      5�      �� 5�      -   5        $ lblPhone��5�      $��2��5�      $��Phone number��5�      ��5�      �� *HorizontalAlignment+$ lblNameCustomer����5�      �� *VerticalAlignment+$ lblNameCustomer����5�      �� *
FontSize+$ lblNameCustomer����5�      �� *
FontWeight+$ lblNameCustomer����5�      �� *
Foreground+$ lblNameCustomer��� 5�      -   5        $ grdPhone��5�      $��2��5�      $��2��5�      ��5�      �� *Margin+$ grdNameCustomer��.+�5�      �� -   5        $	 recPhone��5�      ��5�      �� *ActualWidth+$ recNameCustomer����5�      �� *ActualHeight+$ recNameCustomer����5�      �� *HorizontalAlignment+$ recNameCustomer��
 5�      �� *	RadiusX+$ recNameCustomer�� 5�      �� *	RadiusY+$ recNameCustomer����5�      �� *Stroke+$ recNameCustomer���� 5�      -   5        $ txbPhone��5�      $��10q�5�      $ Customer's Phone number��5�      ��5�      �� *ActualWidth+$ txbNameCustomer����5�      �� *ActualHeight+$ txbNameCustomer����5�      �� *HorizontalAlignment+$ txbNameCustomer����5�      �� *VerticalAlignment+$ txbNameCustomer����5�      �� *HorizontalContentAlignment+$ txbNameCustomer����5�      �� *VerticalContentAlignment+$ txbNameCustomer����5�      �� *BorderThickness+$ txbNameCustomer����5�      �� *
FontSize+$ txbNameCustomer����5�      �� *
FontWeight+$ txbNameCustomer�� 5�      �� *
MaxLines+$ txbNameCustomer��5�      5�      �� 5�      -   5        $ lblEmail��5�      $��3��5�      $��Email��5�      ��5�      �� *HorizontalAlignment+$ lblNameCustomer����5�      �� *VerticalAlignment+$ lblNameCustomer����5�      �� *
FontSize+$ lblNameCustomer����5�      �� *
FontWeight+$ lblNameCustomer����5�      �� *
Foreground+$ lblNameCustomer��� 5�      -   5        $ grdEmail��5�      $��3��5�      $��2��5�      ��5�      �� *Margin+$ grdNameCustomer��.+�5�      �� -   5        $	 recEmail��5�      ��5�      �� *ActualWidth+$ recNameCustomer����5�      �� *ActualHeight+$ recNameCustomer����5�      �� *HorizontalAlignment+$ recNameCustomer��
 5�      �� *	RadiusX+$ recNameCustomer�� 5�      �� *	RadiusY+$ recNameCustomer����5�      �� *Stroke+$ recNameCustomer���� 5�      -   5        $ txbEmail��5�      $��10q�5�      $ Customer's email��5�      ��5�      �� *ActualWidth+$ txbNameCustomer����5�      �� *ActualHeight+$ txbNameCustomer����5�      �� *HorizontalAlignment+$ txbNameCustomer����5�      �� *VerticalAlignment+$ txbNameCustomer����5�      �� *HorizontalContentAlignment+$ txbNameCustomer����5�      �� *VerticalContentAlignment+$ txbNameCustomer����5�      �� *BorderThickness+$ txbNameCustomer����5�      �� *
FontSize+$ txbNameCustomer����5�      �� *
FontWeight+$ txbNameCustomer�� 5�      �� *
MaxLines+$ txbNameCustomer��5�      �� 5�      -   5        $ lbdateCheckIn��5�      $��4��5�      $��Date check in��5�      ��5�      �� *HorizontalAlignment+$ lblNameCustomer����5�      �� *VerticalAlignment+$ lblNameCustomer����5�      �� *
FontSize+$ lblNameCustomer����5�      �� *
FontWeight+$ lblNameCustomer����5�      �� *
Foreground+$ lblNameCustomer��� 5�      -   5        $ grddateCheckIn��5�      $��4��5�      $��2��5�      ��5�      �� *Margin+$ grdNameCustomer��.+�5�      �� -   5        $	 recdateCheckIn��5�      ��5�      �� *ActualWidth+$ recNameCustomer����5�      �� *ActualHeight+$ recNameCustomer����5�      �� *HorizontalAlignment+$ recNameCustomer��
 5�      �� *	RadiusX+$ recNameCustomer�� 5�      �� *	RadiusY+$ recNameCustomer����5�      �� *Stroke+$ recNameCustomer��(  "System.Windows.Controls.DatePicker  5�      -   5          Name$ dpkdateCheckIn��5�      $��10q�5�      -  'MaterialDesignThemes.Wpf.CalendarAssist   IsHeaderVisible$ False��5      $ Customer's Date check in��5     ��5�      �� *ActualWidth+$ txbNameCustomer����5�      �� *ActualHeight+$ txbNameCustomer����5�      �� *HorizontalAlignment+$ txbNameCustomer����5�      �� *VerticalAlignment+$ txbNameCustomer����5�      �� *HorizontalContentAlignment+$ txbNameCustomer����5�      �� *VerticalContentAlignment+$ txbNameCustomer����5     �� *BorderThickness+$ txbNameCustomer����5     �� *
FontSize+$ txbNameCustomer����5     �� *
FontWeight+$ txbNameCustomer��5     � 5     -   5        $ grdSelection��5     $��5��5     $��2��5	     $
��Left=�5     $��Center=�5     ��5
     �� *ActualWidth+$ recNameCustomer����5     �� *Margin+$ grdNameCustomer�� 5     �� 5     �� 5     �� 5     .+�5     �� -   5         ��Name$ 
btnConfirm��5     $��0��5     +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5     ���	#FFF38413$��Confirm��5     $��11(�5     $
��Bold"�5     
������� !  MaterialDesignFlatMidBgButton#��[  5     �� 5     -   5        $ 	btnCancel��5      $��2��5!     $ 10��5"     $��Cancel��5%     $��11(�5&        MaterialDesignOutlinedButton#��[ 5)     ��5#     �� *
Foreground+$ 
btnConfirm����5'     �� *
FontWeight+$ 
btnConfirm����5(     �� *
Background+$ 
btnConfirm��5)     5*     5+     5,     5-     5.     