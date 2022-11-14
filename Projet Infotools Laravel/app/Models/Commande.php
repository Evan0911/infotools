<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Commande extends Model
{
    protected $fillable = [
        'idCli',
    ];

    public function client()
    {
        return $this->belongsTo('App\Models\Client', 'idCli');
    }

    public function produits()
    {
        return $this->belongsToMany('App\Models\Produit', 'ligne_cdes', 'idCde', 'idProd')->withPivot('qte');
    }
}
