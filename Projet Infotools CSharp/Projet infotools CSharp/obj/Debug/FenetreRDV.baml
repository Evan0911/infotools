   M S B A M L   `   `   `  ����R  NProjet infotools CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Projet_infotools_CSharpProjet_infotools_CSharp  5   	   (    "Projet_infotools_CSharp.FenetreRDV   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Projet_infotools_CSharp     5   	     � Title$  FenêtreRDV��5   	   $��649.929��6   $	��971��6-   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DtgRdv��5
         AutoGenerateColumns .  $��	0,147,0,0q�6a   ��6#   ��  �� Path$
 rdvs�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Numéro��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *id+  5      $ Date Rendez-vous��6%    6?   �� *	dateRDV+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Client��6)      CellTemplate 5      �� 5      .R�5      �� ��5   "   `� 5   &    �� StringFormat$ {0} {1}��63   .1�5   *   �� $ cli.nom�62   �� 5   *   $ 
cli.prenom�62   5   '   5      5      5        5      $ 
Commercial��6)    5      �� 5       .R�5!      �� ��5"   "   `� 5#   &   $ {0} {1}��63   .1�5$   *   �� $ com.nom�62   �� 5%   *   $ 
com.prenom�62   5&   '   5(      5)      5+      5.      �� 5/   
   -   5        	 ��Name$	 
BtnAjouter��5/      $��Ajouter rendez-vous��6%   $��Right=�6C   $	��Top=�6_   $	��150��6w   $��	0,10,20,0q�6�   $��34��6�   �� 50   
   -   5        $	 BtnModifier��50      $��Modifier rendez-vous��6&   $��Right=�6E   $	��Top=�6a   $	��150��6y   $��	0,49,20,0q�6�   $��34��6�   6�   �� 51   
   -   5        $	 BtnSupprimerProd��51      $��Supprimer rendez-vous��6+   $��Right=�6K   $	��Top=�6g   $	��150��6   $��	0,88,20,0q�6�   $��34��6�   6�   �� 52   
   -   5        
 ��Name$
 CboCli��52      $
��Left=�6#   $	��Top=�6>   $	��120��6V   $��
226,88,0,0q�6b   ��6v   �� $
 cCli���53      �� 54      .R�55      �� ��56      `� 57      $ {0} {1}��6+   .1�58   "   �� $	 nom�6*   �� 59   "   $ prenom�6*   5:      5<      5=      5?      �� 5@   
   -   5        $
 CboCom��5@      $
��Left=�6#   $	��Top=�6>   $	��120��6V   $��
410,88,0,0q�6b   ��6v   �� $
 cCom���5A      �� 5B      .R�5C      �� ��5D      `� 5E      $ {0} {1}��6+   .1�5F   "   �� $	 nom�6*   �� 5G   "   $ prenom�6*   5H      5J      5K      5M      �� 5N   
   $��Client��6   $
��Left=�6!   $	��Top=�6<   $��
226,49,0,0q�6T   �� 5O   
   $
��Date��6   $
��Left=�6   $	��Top=�6:   $��	34,49,0,0q�6R   �� 5P   
   $��
Commercial��6   $
��Left=�6%   $	��Top=�6@   $��
410,49,0,0q�6X   (  "System.Windows.Controls.DatePicker  5Q   
   -   5          Name$ 
DtpDateRdv��5Q      $
��Left=�6)   $	��Top=�6D   $��	34,88,0,0q�6\   5R      5S      