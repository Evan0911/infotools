<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class LigneCde extends Model
{
    protected $fillable = [
        'idCde', 'idProd', 'qte'
    ];
}
