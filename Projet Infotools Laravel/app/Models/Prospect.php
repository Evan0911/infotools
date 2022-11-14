<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Prospect extends Model
{
    protected $fillable = [
        'nomPros', 'prenomPros', 'adressePros', 'cpPros', 'villePros'
    ];
}
