   M S B A M L   `   `   `  ����L  HHuongDuongVillage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HuongDuongVillageHuongDuongVillage  5      &     HuongDuongVillage.ChangePassword   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HuongDuongVillage     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  Change Password��5	      $	��700��5
      $	��600��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � SizeToContent$ WidthAndHeight=�5      .��5      �� 
����������	#FFF38413$��2q�5   	    �� CornerRadius$ 10��5   	    �� Padding$ 20q�5   	   ._�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      $��5* �6#   .+�5      � -   5         �Name$ restaurantInformation��5      $��0,0,10,0q�62   $��Center=�6D   .+�5      �� $��/GUI/village_logo.png��6   5      � 5      -   5        $ gridInfo��5       $��1��5!      .+�5"      �� $��Center=�6   	 �� Orientation$	 Vertical=�68   .+�5#      � -   5        $ grdEmailContainer��5#      $
��0,15q�66    5$      �� 5%      �� 5&      $
��2.5* �6/   .+�5(      �� -   5        
 ��Name$
 lblEmail��5)      $��Right=�5*      $��Center=�5+      $��Email��5,      $��18(�5-      $
��Bold"�5.      
���   �5/      � 50      -   5        $ grdEmail��51      $��1��52      $��30,0,0,0q�53      .+�54      �� -   5         ��Name$ recEmail��55   !   $	��300��56   !   $��40��57   !   $
��Left=�58   !    �� RadiusX$ 5��59   !    �� RadiusY$ 5��5:   !   
�������5;   !   �� 5<      -   5         ��Name$ txbEmail��5=   !   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Employee's email��5D   !   ��5>   !   �� *ActualWidth+ �� ElementName$ txbPasswordEmployee����5?   !   �� *ActualHeight+$ txbPasswordEmployee����5@   !   �� *HorizontalAlignment+$ txbPasswordEmployee����5A   !   �� *VerticalAlignment+$ txbPasswordEmployee����5B   !   �� *HorizontalContentAlignment+$ txbPasswordEmployee����5C   !   �� *VerticalContentAlignment+$ txbPasswordEmployee����5E   !   �� *	Padding+$ txbPasswordEmployee����5F   !   �� *BorderThickness+$ txbPasswordEmployee����5G   !   �� *
FontSize+$ txbPasswordEmployee����5H   !   �� *
FontWeight+$ txbPasswordEmployee��5I      5J      � 5K      -   5        $ grdVerifyCode��5L      $
��0,15q�5M      $y�Visible=�5N       5O      �� 5P      �� 5Q      $
��2.5* �6/   .+�5S      �� -	   5        $
 lblVerifyCode��5T      $��Right=�5U      $��Center=�5V      $��Verify Code��5W      $��18(�5X      $
��Bold"�5Y      
���   �5Z      � 5[      $��1��6   $��30,0,0,0q�6/   .+�5\      �� -
   5        $ recVerifyCode��5]   !   $ 5��5b   !   $ 5��5c   !   
���������5^   !   �� *ActualWidth+$ recEmail����5_   !   �� *ActualHeight+$ recEmail����5`   !   �� *HorizontalAlignment+$ recEmail��5d   !   �� 5e      -   5        $ txbVerifyCode��5f   !   $ Verify code��5m   !   ��5g   !   �� *ActualWidth+$ txbPasswordEmployee����5h   !   �� *ActualHeight+$ txbPasswordEmployee����5i   !   �� *HorizontalAlignment+$ txbPasswordEmployee����5j   !   �� *VerticalAlignment+$ txbPasswordEmployee����5k   !   �� *HorizontalContentAlignment+$ txbPasswordEmployee����5l   !   �� *VerticalContentAlignment+$ txbPasswordEmployee����5n   !   �� *	Padding+$ txbPasswordEmployee����5o   !   �� *BorderThickness+$ txbPasswordEmployee����5p   !   �� *
FontSize+$ txbPasswordEmployee����5q   !   �� *
FontWeight+$ txbPasswordEmployee�� �� SelectionBrush 5s   !   Z� 5t      5u      � 5v      $
��0,15q�6    5w      �� 5x      �� 5y      $
��2.5* �6/   .+�5{      �� -   5        $
 lblPasswordEmployee��5|      $��2��5}      $��Right=�5~      $��Center=�5      $��New Password��5�      $��18(�5�      $
��Bold"�5�      
���   �5�      � 5�      -   5        $ grdPasswordEmployee��5�      $��1��5�      $��30,0,0,0q�5�      .+�5�      �� -   5        $ recPasswordEmployee��5�   !   $	��300��5�   !   $��40��5�   !   $
��Left=�5�   !   $ 5��5�   !   $ 5��5�   !   
�������5�   !   G� 5�      -   5         G�Name$ txbPasswordEmployee��5�   !   $
��Left=�5�   !   $��Center=�5�   !   $
��Left=�5�   !   $��Center=�5�   !   $ Employee's password��5�   !   $��5q�5�   !   $��0q�5�   !   $��14(�5�   !   $
��Bold"�5�   !   ��5�   !   �� *ActualWidth+$ recPasswordEmployee����5�   !   �� *ActualHeight+$ recPasswordEmployee�� G� SelectionBrush 5�   !   Z� 5�      5�      � 5�      $
��0,15q�6    5�      �� 5�      �� 5�      $
��2.5* �6/   .+�5�      �� -   5        $
 lbConfirmPassword��5�      $��Right=�5�      $��Center=�5�      $��Confirm��5�      $��18(�5�      $
��Bold"�5�      
���   �5�      � 5�      -   5        $ grdConfirmPassword��5�      $��1��5�      $��30,0,0,0q�5�      .+�5�      �� -   5        $ recConfirmPassword��5�   !   $
��Left=�5�   !   $ 5��5�   !   $ 5��5�   !   
���������5�   !   �� *ActualWidth+$ recPasswordEmployee����5�   !   �� *ActualHeight+$ recPasswordEmployee��5�   !   G� 5�      -   5        $ txbConfirmPassword��5�   !   $ Confirm password��5�   !   ��5�   !   �� *ActualWidth+$ txbPasswordEmployee����5�   !   �� *ActualHeight+$ txbPasswordEmployee����5�   !   �� *HorizontalAlignment+$ txbPasswordEmployee����5�   !   �� *VerticalAlignment+$ txbPasswordEmployee����5�   !   �� *HorizontalContentAlignment+$ txbPasswordEmployee����5�   !   �� *VerticalContentAlignment+$ txbPasswordEmployee����5�   !   �� *	Padding+$ txbPasswordEmployee����5�   !   �� *BorderThickness+$ txbPasswordEmployee����5�   !   �� *
FontSize+$ txbPasswordEmployee����5�   !   �� *
FontWeight+$ txbPasswordEmployee�� 5�   !   Z� 5�      5�      � 5�      $
��0,15q�6    5�      �� 5�      �� 5�      $
��2.5* �6/   .+�5�      � -   5        $ grdSelection��5�      $��1��5�      $	��300��5�      $��30,0,0,0q�5�      $
��Left=�5�      $��Center=�5�       5�      �� 5�   "   �� 5�   "   �� 5�   "   .+�5�      �� -   5         ��Name$ 
btnConfirm��5�   !   $��0��5�   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5�   !   ���	#FFF38413$��Confirm��5�   !   $��11(�5�   !   $
��Bold"�5�   !   
������� !  MaterialDesignFlatMidBgButton#��[  5�   !   �� 5�      -   5        $ 	btnCancel��5�   !   $��2��5�   !   $ 10��5�   !   $��Cancel��5�   !   $��11(�5�   !      MaterialDesignOutlinedButton#��[ 5�   !   ��5�   !   �� *
Foreground+$ 
btnConfirm����5�   !   �� *
FontWeight+$ 
btnConfirm����5�   !   �� *
Background+$ 
btnConfirm��5�   !   5�      5�      5�      5�      5�      5�      5�      