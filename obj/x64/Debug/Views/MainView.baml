   M S B A M L   `   `   `  ����  LeapMotionAngel     LeapMotionAngel.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      H DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null:MahApps,http://metro.mahapps.com/winfx/xaml/controls  5      S OMahApps.Metro.IconPacks, Version=2.2.0.12, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5        � Title$  
MainWindow��5      $	��500��5      $	��800��6$   $��0q�5      (  "MahApps.Metro.Controls.MetroWindow   ShowTitleBar .   � DataContext 5      ��    Locator �� Source# [   �� Path$
 Main�   WindowButtonCommands 5      1  +MahApps.Metro.Controls.WindowButtonCommands  5   
    3 /MahApps.Metro.Styles.WindowButtonCommands.Win10#���  6'      IconTemplate 5      �� 5   
   .R�5      � $��20��5      $��20��5      .+�5      �� ��5      !� 5        appbar_3d_obj !� Visual# [ 6&   5      5      5      .��5!      �  � ColumnDefinitions 5"   
   �� 5#      $	��150 �6   �� 5$      	 � RowDefinitions	 5&   
   �� 5'      �� 5(      $��25 �6   .+�5-   
   � $��1��6   $��2��6   .+�5.      �� $��Center=�5/      $��10,0,0,0q�50      $��0q�51        LableStatus#���  54      $��2��68   
���������53      �� *MainModel.Status+
 �� Mode$
 TwoWay=� � 	Resources 55       �� Triggers P� Property P� Value �� Property �� Value��%Y  &	       �� 56       57      P� 58       � ��$ 
Disconnect��6@   . �59   "   ��  � ��
 �  ��6E   5:      P� 5;       � ��$ Connect��6@   . �5<   "   ��  � ��
 �����6E   5=      P� 5>       � ��$ Please Insert LeapMotion��6@   . �5?   "   ��  � �� �	#FFCA51006E   5@      5B      5C      5D      5F      � 5N   
   $��0��6   	 5O      �� 5P      $��10 �6    �� 5Q      $��30 �6    �� 5R      $��30 �6    �� 5S       5U      �� 5V      �� 5W      .+�5Z      �� $��	选择手��6   $��1��6#   �� 5[      -   5         ��Name$ comboBox��5[      $��1��6)   $��1��69   .@�5\      �� $
��手1��6   �� 5]      $
��手2��6   5^      5_      � 5b   
   $��1��6    5c      �� 5d      $��50 �6#   �� 5e      $��50 �6#   �� 5f      $��50 �6#   �� 5g      $��50 �6#   �� 5i      $��1* �6#   	 5k      �� 5l      $��30 �6    �� 5m      $��30 �6    �� 5n      $��30 �6    �� 5o      $��30 �6    �� 5p      $��30 �6    �� 5q      $��30 �6    �� 5r      .+�5v      �� $��食指��6   $��2��5w      �� 5x      $��2��5z      $��1��5{      ��5y      �� *MainModel.FingerBoneFirAngel+$
 TwoWay=�5{      �� 5|      $��2��5~      $��2��5      ��5}      �� *" MainModel.FingerBoneSencondAngel+$
 TwoWay=�5      �� 5�      $��2��5�      $��3��5�      ��5�      �� * MainModel.FingerBoneThirdAngel+$
 TwoWay=�5�      �� 5�      $��	大拇指��6   $��1��5�      �� 5�      $��1��5�      $��1��5�      ��5�      �� *!MainModel.FirFingerBoneFirAngel+$
 TwoWay=�5�      �� 5�      $��1��5�      $��2��5�      ��5�      �� *%#MainModel.FirFingerBoneSencondAngel+$
 TwoWay=�5�      �� 5�      $��1��5�      $��3��5�      ��5�      �� *#!MainModel.FirFingerBoneThirdAngel+$
 TwoWay=�5�      �� 5�      $��中指��6   $��3��5�      �� 5�      $��3��5�      $��1��5�      ��5�      �� *$"MainModel.SecondFingerBoneFirAngel+$
 TwoWay=�5�      �� 5�      $��3��5�      $��2��5�      ��5�      �� *(&MainModel.SecondFingerBoneSencondAngel+$
 TwoWay=�5�      �� 5�      $��3��5�      $��3��5�      ��5�      �� *'%MainModel.SencondFingerBoneThirdAngel+$
 TwoWay=�5�      �� 5�      $��	无名指��6   $��4��5�      �� 5�      $��4��5�      $��1��5�      ��5�      �� *&$MainModel.ThirdFirFingerBoneFirAngel+$
 TwoWay=�5�      �� 5�      $��4��5�      $��2��5�      ��5�      �� *'%MainModel.ThirdFingerBoneSencondAngel+$
 TwoWay=�5�      �� 5�      $��4��5�      $��3��5�      ��5�      �� *%#MainModel.ThirdFingerBoneThirdAngel+$
 TwoWay=�5�      �� 5�      $��	小拇指��6   $��5��5�      �� 5�      $��5��5�      $��1��5�      ��5�      �� *" MainModel.LastFingerBoneFirAngel+$
 TwoWay=�5�      �� 5�      $��5��5�      $��2��5�      ��5�      �� *&$MainModel.LastFingerBoneSencondAngel+$
 TwoWay=�5�      �� 5�      $��5��5�      $��3��5�      ��5�      �� *$"MainModel.LastFingerBoneThirdAngel+$
 TwoWay=�5�      5�      5�      5�      