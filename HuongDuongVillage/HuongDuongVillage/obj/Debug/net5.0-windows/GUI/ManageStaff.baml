   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HuongDuongVillage.GUIHuongDuongVillage.GUI  5      #    HuongDuongVillage.ManageStaff   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:HuongDuongVillage.GUI     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  Manage Staff��5	      $	��800��5
      $	��500��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      �� 
����������	#FFF38413$��2q�5   	    �� CornerRadius$ 10��5   	   ._�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      $��2* �6#   .+�5      � -   5         �Name$ vilageInformation��5      $��Center=�6.   .+�5      �� $��/GUI/village_logo.png��6   5      � 5      -   5        $ gridInfo��5      $��1��5      $��0,20,0,0q�5        � RowDefinitions 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(       5*      �� 5+      �� 5,      $��3* �6'   .+�5.      �� -   5         ��Name$ lblName��5/      $��0��50      $��Right=�51      $��Center=�52      $
��Name��53      $��18(�54      $
��Bold"�55      
���   �56      � 57      -   5        $ grdName��58      $��1��59      $��50,0,0,0q�5:      .+�5;      �� -   5        	 ��Name$	 recName��5<      $	��300��5=      $��40��5>      $
��Left=�5?      
 �� RadiusX$
 5��5@       �� RadiusY$ 5��5A      
�������5B      �� 5C      -   5         ��Name$ txbName��5D      $��5q�5G      $
��Left=�5H      $��Center=�5I      $
��Left=�5J      $��Center=�5K      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Staff's Name��5L      $��0q�5M      $��14(�5N      $
��Bold"�5O       �� MaxLines$ 1��5P      ��5E      �� *ActualWidth+ �� ElementName$ recName����5F      �� *ActualHeight+$ recName��5P      5Q      �� 5R      -   5        $ lblUserName��5S      $��1��5T      $��Username��5W      ��5U      �� *HorizontalAlignment+$ lblName����5V      �� *VerticalAlignment+$ lblName����5X      �� *
FontSize+$ lblName����5Y      �� *
FontWeight+$ lblName����5Z      �� *
Foreground+$ lblName��� 5[      -   5        $ grdUserName��5\      $��1��5]      $��1��5^      ��5_      �� *ActualWidth+$ recName����5`      �� *Margin+$ grdName����5a      �� *HorizontalAlignment+$ recName��.+�5b      �� -	   5        $	 recUserName��5c      ��5d      �� *ActualWidth+$ recName����5e      �� *ActualHeight+$ recName����5f      �� *Margin+$ recName����5g      �� *HorizontalAlignment+$ recName��
 5h      �� *	RadiusX+$ recName�� 5i      �� *	RadiusY+$ recName����5j      �� *Stroke+$ recName���� 5k      -
   5        $ txbUserName��5l      $ Staff's username��5t      ��5m      �� *ActualWidth+$ txbName����5n      �� *ActualHeight+$ txbName����5o      �� *	Padding+$ txbName����5p      �� *HorizontalAlignment+$ txbName����5q      �� *VerticalAlignment+$ txbName����5r      �� *HorizontalContentAlignment+$ txbName����5s      �� *VerticalContentAlignment+$ txbName����5u      �� *BorderThickness+$ txbName����5v      �� *
FontSize+$ txbName����5w      �� *
FontWeight+$ txbName�� 5x      �� *
MaxLines+$ txbName��5y      �� 5z      -   5        $ lbSex��5{      $��2��5|      $	��Sex��5      ��5}      �� *HorizontalAlignment+$ lblName����5~      �� *VerticalAlignment+$ lblName����5�      �� *
FontSize+$ lblName����5�      �� *
FontWeight+$ lblName����5�      �� *
Foreground+$ lblName��� 5�      -   5        $ grdSex��5�      $��2��5�      $��1��5�      ��5�      �� *ActualWidth+$ recName����5�      �� *Margin+$ grdName����5�      �� *HorizontalAlignment+$ recName�� 5�      �� 5�      �� 5�      .+�5�      	� -   5         	�Name$ rdoMale��5�      $
��Left=�5�      $��Center=�5�      $
��Male��5�      $��16(�5�       d� 	IsChecked$
 TrueY�5�       "  MaterialDesignLightRadioButton#��[  5�      	� 5�      -   5        $ 	rdoFemale��5�      $��1��5�      $��Female��5�      #��[  5�      ��5�      �� *HorizontalAlignment+$ rdoMale����5�      �� *VerticalAlignment+$ rdoMale����5�      �� *
FontSize+$ rdoMale��5�      5�      �� 5�      -   5        $ lbRole��5�      $��3��5�      $
��Role��5�      ��5�      �� *HorizontalAlignment+$ lblName����5�      �� *VerticalAlignment+$ lblName����5�      �� *
FontSize+$ lblName����5�      �� *
FontWeight+$ lblName����5�      �� *
Foreground+$ lblName��� 5�      -   5        $ grdRole��5�      $��3��5�      $��1��5�      ��5�      �� *Margin+$ grdName��.+�5�      �� -   5        $	 recRole��5�      ��5�      �� *ActualWidth+$ recName����5�      �� *ActualHeight+$ recName����5�      �� *Margin+$ recName����5�      �� *HorizontalAlignment+$ recName��
 5�      �� *	RadiusX+$ recName�� 5�      �� *	RadiusY+$ recName����5�      �� *Stroke+$ recName���� 5�      -   5         ��Name$ cmbRole��5�      $��Center=�5�      $ Staff's Role��5�       �� SelectedValuePath$ Content��5�      ��5�      �� *ActualWidth+$ recName����5�      �� *ActualHeight+$ recName����5�      �� *	Padding+$ txbName����5�      �� *HorizontalAlignment+$ txbName����5�      �� *
FontWeight+$ txbName��.@�5�      �� $��HR��6'   �� 5�      $	��CEO��6'   �� 5�      $��Receptionist��6'   �� 5�      $
��Sale��6'   �� 5�      $��
Accountant��6'   �� 5�      $	��Bar��6'   �� 5�      $
��Chef��6'   �� 5�      $��Cleaner��6'   ��5�      �� 5�      .R�5�   "   $� 5�      5�      5�      �� 5�      -   5        $ lblEmail��5�      $��4��5�      $��Email��5�      ��5�      �� *HorizontalAlignment+$ lblName����5�      �� *VerticalAlignment+$ lblName����5�      �� *
FontSize+$ lblName����5�      �� *
FontWeight+$ lblName����5�      �� *
Foreground+$ lblName��� 5�      -   5        $ grdEmail��5�      $��4��5�      $��1��5�      ��5�      �� *Margin+$ grdName��.+�5�      �� -   5        $	 recEmail��5�      ��5�      �� *ActualWidth+$ recName����5�      �� *ActualHeight+$ recName����5�      �� *HorizontalAlignment+$ recName��
 5�      �� *	RadiusX+$ recName�� 5�      �� *	RadiusY+$ recName����5�      �� *Stroke+$ recName���� 5�      -   5        $ txbEmail��5�      $ Staff's email��5�      ��5�      �� *ActualWidth+$ txbName����5�      �� *ActualHeight+$ txbName����5�      �� *	Padding+$ txbName����5�      �� *HorizontalAlignment+$ txbName����5�      �� *VerticalAlignment+$ txbName����5�      �� *HorizontalContentAlignment+$ txbName����5�      �� *VerticalContentAlignment+$ txbName����5�      �� *BorderThickness+$ txbName����5�      �� *
FontSize+$ txbName����5�      �� *
FontWeight+$ txbName�� 5�      �� *
MaxLines+$ txbName��5�      �� 5�      -   5        $ lblDOB��5�      $��5��5�      $��Date of Birth��5�      ��5�      �� *HorizontalAlignment+$ lblName����5�      �� *VerticalAlignment+$ lblName����5�      �� *
FontSize+$ lblName����5�      �� *
FontWeight+$ lblName����5�      �� *
Foreground+$ lblName��� 5�      -   5        $ grdDOB��5�      $��5��5�      $��1��5      ��5     �� *Margin+$ grdName��.+�5     �� -   5        $	 recDOB��5     ��5     �� *ActualWidth+$ recName����5     �� *ActualHeight+$ recName����5     �� *HorizontalAlignment+$ recName��
 5     �� *	RadiusX+$ recName�� 5     �� *	RadiusY+$ recName����5	     �� *Stroke+$ recName��(  "System.Windows.Controls.DatePicker  5     -   5          Name$ dpkDOB��5     -  'MaterialDesignThemes.Wpf.CalendarAssist   IsHeaderVisible$ False��5     $ Staff's Date of Birth��5     ��5     �� *ActualWidth+$ txbName����5     �� *ActualHeight+$ txbName����5     �� *	Padding+$ txbName����5     �� *HorizontalAlignment+$ txbName����5     �� *VerticalAlignment+$ txbName����5     �� *HorizontalContentAlignment+$ txbName����5     �� *VerticalContentAlignment+$ txbName����5     �� *BorderThickness+$ txbName����5     �� *
FontSize+$ txbName����5     �� *
FontWeight+$ txbName��5     � 5     -   5        $ grdSelection��5     $��7��5     $��1��5     $
��Left=�5      $��Center=�5!     ��5     �� *ActualWidth+$ recName����5     �� *Margin+$ grdName�� 5"     �� 5#     �� 5$     �� 5%     .+�5'     �� -   5         ��Name$ 
btnConfirm��5(     $��0��5)     +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5*     ���	#FFF38413$��Confirm��5-     $��11(�5.     $
��Bold"�5/     
������� ! MaterialDesignFlatMidBgButton#��[ 51     �� 53     -   5        $ 	btnCancel��54     $��2��55     $ 10��56     $��Cancel��59     $��11(�5:        MaterialDesignOutlinedButton#��[ 5=     ��57     �� *
Foreground+$ 
btnConfirm����5;     �� *
FontWeight+$ 
btnConfirm����5<     �� *
Background+$ 
btnConfirm��5=     5>     5?     5@     5A     5B     