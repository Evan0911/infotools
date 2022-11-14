<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Rdv extends Model
{
    protected $fillable = [
        'dateRdv', 'idCli', 'idPro'
    ];

    public function client()
    {
        return $this->belongsTo('App\Models\Client', 'idCli');
    }
    public function prospect()
    {
        return $this->belongsTo('App\Models\Prospect', 'idPro');
    }
    public function user()
    {
        return $this->belongsTo('App\Models\User', 'idPro');
    }
}
